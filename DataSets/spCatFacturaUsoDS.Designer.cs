﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 1591

namespace RedCoForm.DataSets {
    
    
    /// <summary>
    ///Represents a strongly typed in-memory cache of data.
    ///</summary>
    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("spCatFacturaUsoDS")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class spCatFacturaUsoDS : global::System.Data.DataSet {
        
        private spCatFacturaUsoDataTable tablespCatFacturaUso;
        
        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public spCatFacturaUsoDS() {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected spCatFacturaUsoDS(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                base(info, context, false) {
            if ((this.IsBinarySerialized(info, context) == true)) {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["spCatFacturaUso"] != null)) {
                    base.Tables.Add(new spCatFacturaUsoDataTable(ds.Tables["spCatFacturaUso"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public spCatFacturaUsoDataTable spCatFacturaUso {
            get {
                return this.tablespCatFacturaUso;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode {
            get {
                return this._schemaSerializationMode;
            }
            set {
                this._schemaSerializationMode = value;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables {
            get {
                return base.Tables;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations {
            get {
                return base.Relations;
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override void InitializeDerivedDataSet() {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public override global::System.Data.DataSet Clone() {
            spCatFacturaUsoDS cln = ((spCatFacturaUsoDS)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader) {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema)) {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["spCatFacturaUso"] != null)) {
                    base.Tables.Add(new spCatFacturaUsoDataTable(ds.Tables["spCatFacturaUso"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.ReadXml(reader);
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal void InitVars() {
            this.InitVars(true);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        internal void InitVars(bool initTable) {
            this.tablespCatFacturaUso = ((spCatFacturaUsoDataTable)(base.Tables["spCatFacturaUso"]));
            if ((initTable == true)) {
                if ((this.tablespCatFacturaUso != null)) {
                    this.tablespCatFacturaUso.InitVars();
                }
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void InitClass() {
            this.DataSetName = "spCatFacturaUsoDS";
            this.Prefix = "";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablespCatFacturaUso = new spCatFacturaUsoDataTable();
            base.Tables.Add(this.tablespCatFacturaUso);
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private bool ShouldSerializespCatFacturaUso() {
            return false;
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
            spCatFacturaUsoDS ds = new spCatFacturaUsoDS();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace)) {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length)) {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length) 
                                        && (s1.ReadByte() == s2.ReadByte())); ) {
                                ;
                            }
                            if ((s1.Position == s1.Length)) {
                                return type;
                            }
                        }
                    }
                }
                finally {
                    if ((s1 != null)) {
                        s1.Close();
                    }
                    if ((s2 != null)) {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public delegate void spCatFacturaUsoRowChangeEventHandler(object sender, spCatFacturaUsoRowChangeEvent e);
        
        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class spCatFacturaUsoDataTable : global::System.Data.TypedTableBase<spCatFacturaUsoRow> {
            
            private global::System.Data.DataColumn columnFacturaUsoID;
            
            private global::System.Data.DataColumn columnCodigoSAT;
            
            private global::System.Data.DataColumn columnDescripcion;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoDataTable() {
                this.TableName = "spCatFacturaUso";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal spCatFacturaUsoDataTable(global::System.Data.DataTable table) {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected spCatFacturaUsoDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : 
                    base(info, context) {
                this.InitVars();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn FacturaUsoIDColumn {
                get {
                    return this.columnFacturaUsoID;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn CodigoSATColumn {
                get {
                    return this.columnCodigoSAT;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRow this[int index] {
                get {
                    return ((spCatFacturaUsoRow)(this.Rows[index]));
                }
            }
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event spCatFacturaUsoRowChangeEventHandler spCatFacturaUsoRowChanging;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event spCatFacturaUsoRowChangeEventHandler spCatFacturaUsoRowChanged;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event spCatFacturaUsoRowChangeEventHandler spCatFacturaUsoRowDeleting;
            
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public event spCatFacturaUsoRowChangeEventHandler spCatFacturaUsoRowDeleted;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void AddspCatFacturaUsoRow(spCatFacturaUsoRow row) {
                this.Rows.Add(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRow AddspCatFacturaUsoRow(int FacturaUsoID, string CodigoSAT, string Descripcion) {
                spCatFacturaUsoRow rowspCatFacturaUsoRow = ((spCatFacturaUsoRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        FacturaUsoID,
                        CodigoSAT,
                        Descripcion};
                rowspCatFacturaUsoRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowspCatFacturaUsoRow);
                return rowspCatFacturaUsoRow;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRow FindByFacturaUsoID(int FacturaUsoID) {
                return ((spCatFacturaUsoRow)(this.Rows.Find(new object[] {
                            FacturaUsoID})));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public override global::System.Data.DataTable Clone() {
                spCatFacturaUsoDataTable cln = ((spCatFacturaUsoDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance() {
                return new spCatFacturaUsoDataTable();
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal void InitVars() {
                this.columnFacturaUsoID = base.Columns["FacturaUsoID"];
                this.columnCodigoSAT = base.Columns["CodigoSAT"];
                this.columnDescripcion = base.Columns["Descripcion"];
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            private void InitClass() {
                this.columnFacturaUsoID = new global::System.Data.DataColumn("FacturaUsoID", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnFacturaUsoID);
                this.columnCodigoSAT = new global::System.Data.DataColumn("CodigoSAT", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCodigoSAT);
                this.columnDescripcion = new global::System.Data.DataColumn("Descripcion", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnDescripcion);
                this.Constraints.Add(new global::System.Data.UniqueConstraint("PK_spCatFacturaUso", new global::System.Data.DataColumn[] {
                                this.columnFacturaUsoID}, true));
                this.columnFacturaUsoID.AllowDBNull = false;
                this.columnFacturaUsoID.Unique = true;
                this.columnCodigoSAT.MaxLength = 20;
                this.columnDescripcion.MaxLength = 100;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRow NewspCatFacturaUsoRow() {
                return ((spCatFacturaUsoRow)(this.NewRow()));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder) {
                return new spCatFacturaUsoRow(builder);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override global::System.Type GetRowType() {
                return typeof(spCatFacturaUsoRow);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.spCatFacturaUsoRowChanged != null)) {
                    this.spCatFacturaUsoRowChanged(this, new spCatFacturaUsoRowChangeEvent(((spCatFacturaUsoRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.spCatFacturaUsoRowChanging != null)) {
                    this.spCatFacturaUsoRowChanging(this, new spCatFacturaUsoRowChangeEvent(((spCatFacturaUsoRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.spCatFacturaUsoRowDeleted != null)) {
                    this.spCatFacturaUsoRowDeleted(this, new spCatFacturaUsoRowChangeEvent(((spCatFacturaUsoRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.spCatFacturaUsoRowDeleting != null)) {
                    this.spCatFacturaUsoRowDeleting(this, new spCatFacturaUsoRowChangeEvent(((spCatFacturaUsoRow)(e.Row)), e.Action));
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void RemovespCatFacturaUsoRow(spCatFacturaUsoRow row) {
                this.Rows.Remove(row);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs) {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                spCatFacturaUsoDS ds = new spCatFacturaUsoDS();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "spCatFacturaUsoDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace)) {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); ) {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length)) {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length) 
                                            && (s1.ReadByte() == s2.ReadByte())); ) {
                                    ;
                                }
                                if ((s1.Position == s1.Length)) {
                                    return type;
                                }
                            }
                        }
                    }
                    finally {
                        if ((s1 != null)) {
                            s1.Close();
                        }
                        if ((s2 != null)) {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }
        
        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class spCatFacturaUsoRow : global::System.Data.DataRow {
            
            private spCatFacturaUsoDataTable tablespCatFacturaUso;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            internal spCatFacturaUsoRow(global::System.Data.DataRowBuilder rb) : 
                    base(rb) {
                this.tablespCatFacturaUso = ((spCatFacturaUsoDataTable)(this.Table));
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public int FacturaUsoID {
                get {
                    return ((int)(this[this.tablespCatFacturaUso.FacturaUsoIDColumn]));
                }
                set {
                    this[this.tablespCatFacturaUso.FacturaUsoIDColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string CodigoSAT {
                get {
                    try {
                        return ((string)(this[this.tablespCatFacturaUso.CodigoSATColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'CodigoSAT\' in table \'spCatFacturaUso\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablespCatFacturaUso.CodigoSATColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablespCatFacturaUso.DescripcionColumn]));
                    }
                    catch (global::System.InvalidCastException e) {
                        throw new global::System.Data.StrongTypingException("The value for column \'Descripcion\' in table \'spCatFacturaUso\' is DBNull.", e);
                    }
                }
                set {
                    this[this.tablespCatFacturaUso.DescripcionColumn] = value;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsCodigoSATNull() {
                return this.IsNull(this.tablespCatFacturaUso.CodigoSATColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetCodigoSATNull() {
                this[this.tablespCatFacturaUso.CodigoSATColumn] = global::System.Convert.DBNull;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablespCatFacturaUso.DescripcionColumn);
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public void SetDescripcionNull() {
                this[this.tablespCatFacturaUso.DescripcionColumn] = global::System.Convert.DBNull;
            }
        }
        
        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
        public class spCatFacturaUsoRowChangeEvent : global::System.EventArgs {
            
            private spCatFacturaUsoRow eventRow;
            
            private global::System.Data.DataRowAction eventAction;
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRowChangeEvent(spCatFacturaUsoRow row, global::System.Data.DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public spCatFacturaUsoRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")]
            public global::System.Data.DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}

#pragma warning restore 1591