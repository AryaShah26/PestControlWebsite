﻿using CPS.Business;
using CPS.Common;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CPS.Views.Reports
{
    /// <summary>
    /// Interaction logic for TotalChequePrintReport.xaml
    /// </summary>
    public partial class TotalChequePrintReport : UserControl
    {
        public TotalChequePrintReport()
        {
            InitializeComponent();
            BindComboBox();
            btnPrint.IsEnabled = false;
        }

        private void BindComboBox()
        {
            var source = BranchMasterDTO.GetLookups();
            source.Insert(0, new LookupItem<int, string> { Key = 0, Value = "ALL" });
            cbBrach.ItemsSource = source;
            cbBrach.DisplayMemberPath = "Value";
            cbBrach.SelectedValuePath = "Key";
        }

        private void btnShowColumns_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new CPSDbContext())
            {
                var repositoryRequest = new PersistenceBase<RequestDTO>(context);
                var repositoryBranch = new PersistenceBase<BranchMasterDTO>(context);
                var repositoryAccountType = new PersistenceBase<AccountTypeDTO>(context);
                var repositoryPrintHistory = new PersistenceBase<PrintHistoryDTO>(context);

                var branchId = cbBrach.SelectedValue == null ? 0 : (int)cbBrach.SelectedValue;
                var transactionfromDate = string.IsNullOrWhiteSpace(dtPrintDateFrom.Text) ? System.DateTime.Now.Date : System.Convert.ToDateTime(dtPrintDateFrom.Text);
                var transactiontoDate = string.IsNullOrWhiteSpace(dtPrintDateTo.Text) ? System.DateTime.Now.Date : System.Convert.ToDateTime(dtPrintDateTo.Text);

                var query = (from r in repositoryRequest.GetAll()
                             join b in repositoryBranch.GetAll() on r.BranchId equals b.Id
                             join at in repositoryAccountType.GetAll() on r.TransactionCode equals at.Code
                             join ph in repositoryPrintHistory.GetAll() on r.Id equals ph.RequestId
                             where (branchId == 0 || (branchId != 0 && r.BranchId == branchId))
                             && DbFunctions.TruncateTime(ph.CreatedOn) >= transactionfromDate.Date && DbFunctions.TruncateTime(ph.CreatedOn) <= transactiontoDate.Date
                             && ph.PrintType == PrintType.ChequeBook && r.IsPrinted
                             select new { r, b, at, ph, BookSize = ph.ChequeNoTo - ph.ChequeNoFrom + 1 });

                var groupedQuery = (from o in query
                                    group o by new { o.r.BranchId, o.b.Name, o.r.TransactionCode, o.BookSize } into g
                                    select new TotalPrintReport { BranchName = g.Key.Name, TransactionCode = g.Key.TransactionCode.ToString(), BookSize = g.Key.BookSize, TotalPrint = g.Count(), TotalLeaves = g.Sum(a => a.BookSize) });

                var response = groupedQuery.OrderBy(o => o.BranchName).ToList();

                var resultDataSource = new List<TotalPrintReport>();
                if (response.Count > 0)
                {
                    //Get Distinct BranchName
                    var olDistinctBranch = response.Select(o => o.BranchName).Distinct().ToList();

                    var oGrandTotalPrint = new TotalPrintReport();
                    oGrandTotalPrint.BranchName = "";
                    oGrandTotalPrint.TransactionCode = "Grand Total";
                    oGrandTotalPrint.TotalPrint = response.Sum(o => o.TotalPrint);
                    oGrandTotalPrint.TotalLeaves = response.Sum(o => o.TotalLeaves);

                    foreach (var branch in olDistinctBranch)
                    {
                        resultDataSource.AddRange(response.Where(o => o.BranchName == branch));
                        var oTotalPrint = new TotalPrintReport();
                        oTotalPrint.BranchName = branch;
                        oTotalPrint.TransactionCode = "Sub Total";
                        oTotalPrint.TotalPrint = response.Where(o => o.BranchName == branch).Sum(o => o.TotalPrint);
                        oTotalPrint.TotalLeaves = response.Where(o => o.BranchName == branch).Sum(o => o.TotalLeaves);
                        resultDataSource.Add(oTotalPrint);
                    }
                    resultDataSource.Add(oGrandTotalPrint);
                }

                dgTotalChequePrint.ItemsSource = resultDataSource;

                btnPrint.IsEnabled = true;
                if (response.Count == 0)
                {
                    btnPrint.IsEnabled = false;
                    MessageBox.Show("No records found!", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            Paragraph title = new Paragraph(string.Format("Total Cheque Print:- From:{0}  - To:{1}", (dtPrintDateFrom.SelectedDate ?? DateTime.Now.Date).ToString("dd MMM yyyy"), (dtPrintDateTo.SelectedDate ?? DateTime.Now.Date).ToString("dd MMM yyyy")), new Font(Font.FontFamily.HELVETICA, 15));
            title.Alignment = Element.ALIGN_CENTER;

            ReportPDF report = new ReportPDF(dgTotalChequePrint, new float[] { 200, 75, 75, 75, 75 });
            report.Generate("TotalChequePrint", title);
        }
    }

    public class TotalPrintReport
    {
        public string BranchName { get; set; }
        public string TransactionCode { get; set; }
        public int? BookSize { get; set; }
        public int TotalPrint { get; set; }
        public int TotalLeaves { get; set; }
    }
}
