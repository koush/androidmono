namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.DatabaseMetaData_))]
	public interface DatabaseMetaData  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getURL();
		bool isReadOnly();
		global::java.sql.ResultSet getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3);
		global::java.sql.Connection getConnection();
		global::java.lang.String getUserName();
		int getResultSetHoldability();
		bool allProceduresAreCallable();
		bool allTablesAreSelectable();
		bool nullsAreSortedHigh();
		bool nullsAreSortedLow();
		bool nullsAreSortedAtStart();
		bool nullsAreSortedAtEnd();
		global::java.lang.String getDatabaseProductName();
		global::java.lang.String getDatabaseProductVersion();
		global::java.lang.String getDriverName();
		global::java.lang.String getDriverVersion();
		int getDriverMajorVersion();
		int getDriverMinorVersion();
		bool usesLocalFiles();
		bool usesLocalFilePerTable();
		bool supportsMixedCaseIdentifiers();
		bool storesUpperCaseIdentifiers();
		bool storesLowerCaseIdentifiers();
		bool storesMixedCaseIdentifiers();
		bool supportsMixedCaseQuotedIdentifiers();
		bool storesUpperCaseQuotedIdentifiers();
		bool storesLowerCaseQuotedIdentifiers();
		bool storesMixedCaseQuotedIdentifiers();
		global::java.lang.String getIdentifierQuoteString();
		global::java.lang.String getSQLKeywords();
		global::java.lang.String getNumericFunctions();
		global::java.lang.String getStringFunctions();
		global::java.lang.String getSystemFunctions();
		global::java.lang.String getTimeDateFunctions();
		global::java.lang.String getSearchStringEscape();
		global::java.lang.String getExtraNameCharacters();
		bool supportsAlterTableWithAddColumn();
		bool supportsAlterTableWithDropColumn();
		bool supportsColumnAliasing();
		bool nullPlusNonNullIsNull();
		bool supportsConvert(int arg0, int arg1);
		bool supportsConvert();
		bool supportsTableCorrelationNames();
		bool supportsDifferentTableCorrelationNames();
		bool supportsExpressionsInOrderBy();
		bool supportsOrderByUnrelated();
		bool supportsGroupBy();
		bool supportsGroupByUnrelated();
		bool supportsGroupByBeyondSelect();
		bool supportsLikeEscapeClause();
		bool supportsMultipleResultSets();
		bool supportsMultipleTransactions();
		bool supportsNonNullableColumns();
		bool supportsMinimumSQLGrammar();
		bool supportsCoreSQLGrammar();
		bool supportsExtendedSQLGrammar();
		bool supportsANSI92EntryLevelSQL();
		bool supportsANSI92IntermediateSQL();
		bool supportsANSI92FullSQL();
		bool supportsIntegrityEnhancementFacility();
		bool supportsOuterJoins();
		bool supportsFullOuterJoins();
		bool supportsLimitedOuterJoins();
		global::java.lang.String getSchemaTerm();
		global::java.lang.String getProcedureTerm();
		global::java.lang.String getCatalogTerm();
		bool isCatalogAtStart();
		global::java.lang.String getCatalogSeparator();
		bool supportsSchemasInDataManipulation();
		bool supportsSchemasInProcedureCalls();
		bool supportsSchemasInTableDefinitions();
		bool supportsSchemasInIndexDefinitions();
		bool supportsSchemasInPrivilegeDefinitions();
		bool supportsCatalogsInDataManipulation();
		bool supportsCatalogsInProcedureCalls();
		bool supportsCatalogsInTableDefinitions();
		bool supportsCatalogsInIndexDefinitions();
		bool supportsCatalogsInPrivilegeDefinitions();
		bool supportsPositionedDelete();
		bool supportsPositionedUpdate();
		bool supportsSelectForUpdate();
		bool supportsStoredProcedures();
		bool supportsSubqueriesInComparisons();
		bool supportsSubqueriesInExists();
		bool supportsSubqueriesInIns();
		bool supportsSubqueriesInQuantifieds();
		bool supportsCorrelatedSubqueries();
		bool supportsUnion();
		bool supportsUnionAll();
		bool supportsOpenCursorsAcrossCommit();
		bool supportsOpenCursorsAcrossRollback();
		bool supportsOpenStatementsAcrossCommit();
		bool supportsOpenStatementsAcrossRollback();
		int getMaxBinaryLiteralLength();
		int getMaxCharLiteralLength();
		int getMaxColumnNameLength();
		int getMaxColumnsInGroupBy();
		int getMaxColumnsInIndex();
		int getMaxColumnsInOrderBy();
		int getMaxColumnsInSelect();
		int getMaxColumnsInTable();
		int getMaxConnections();
		int getMaxCursorNameLength();
		int getMaxIndexLength();
		int getMaxSchemaNameLength();
		int getMaxProcedureNameLength();
		int getMaxCatalogNameLength();
		int getMaxRowSize();
		bool doesMaxRowSizeIncludeBlobs();
		int getMaxStatementLength();
		int getMaxStatements();
		int getMaxTableNameLength();
		int getMaxTablesInSelect();
		int getMaxUserNameLength();
		int getDefaultTransactionIsolation();
		bool supportsTransactions();
		bool supportsTransactionIsolationLevel(int arg0);
		bool supportsDataDefinitionAndDataManipulationTransactions();
		bool supportsDataManipulationTransactionsOnly();
		bool dataDefinitionCausesTransactionCommit();
		bool dataDefinitionIgnoredInTransactions();
		global::java.sql.ResultSet getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getSchemas();
		global::java.sql.ResultSet getSchemas(java.lang.String arg0, java.lang.String arg1);
		global::java.sql.ResultSet getCatalogs();
		global::java.sql.ResultSet getTableTypes();
		global::java.sql.ResultSet getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
		global::java.sql.ResultSet getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4);
		global::java.sql.ResultSet getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5);
		global::java.sql.ResultSet getTypeInfo();
		global::java.sql.ResultSet getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4);
		bool supportsResultSetType(int arg0);
		bool supportsResultSetConcurrency(int arg0, int arg1);
		bool ownUpdatesAreVisible(int arg0);
		bool ownDeletesAreVisible(int arg0);
		bool ownInsertsAreVisible(int arg0);
		bool othersUpdatesAreVisible(int arg0);
		bool othersDeletesAreVisible(int arg0);
		bool othersInsertsAreVisible(int arg0);
		bool updatesAreDetected(int arg0);
		bool deletesAreDetected(int arg0);
		bool insertsAreDetected(int arg0);
		bool supportsBatchUpdates();
		global::java.sql.ResultSet getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3);
		bool supportsSavepoints();
		bool supportsNamedParameters();
		bool supportsMultipleOpenResults();
		bool supportsGetGeneratedKeys();
		global::java.sql.ResultSet getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		bool supportsResultSetHoldability(int arg0);
		int getDatabaseMajorVersion();
		int getDatabaseMinorVersion();
		int getJDBCMajorVersion();
		int getJDBCMinorVersion();
		int getSQLStateType();
		bool locatorsUpdateCopy();
		bool supportsStatementPooling();
		bool supportsStoredFunctionsUsingCallSyntax();
		bool autoCommitFailureClosesAllResultSets();
		global::java.sql.ResultSet getClientInfoProperties();
		global::java.sql.ResultSet getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		global::java.sql.ResultSet getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.DatabaseMetaData))]
	public sealed partial class DatabaseMetaData_ : java.lang.Object, DatabaseMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatabaseMetaData_()
		{
			InitJNI();
		}
		internal DatabaseMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getURL18644;
		 global::java.lang.String java.sql.DatabaseMetaData.getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getURL18644)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getURL18644)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly18645;
		 bool java.sql.DatabaseMetaData.isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isReadOnly18645);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isReadOnly18645);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes18646;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getAttributes18646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getAttributes18646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTables18647;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTables18647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTables18647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18648;
		 global::java.sql.Connection java.sql.DatabaseMetaData.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getConnection18648)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getConnection18648)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getUserName18649;
		 global::java.lang.String java.sql.DatabaseMetaData.getUserName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUserName18649)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUserName18649)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability18650;
		 int java.sql.DatabaseMetaData.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getResultSetHoldability18650);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getResultSetHoldability18650);
		}
		internal static global::MonoJavaBridge.MethodId _allProceduresAreCallable18651;
		 bool java.sql.DatabaseMetaData.allProceduresAreCallable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allProceduresAreCallable18651);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allProceduresAreCallable18651);
		}
		internal static global::MonoJavaBridge.MethodId _allTablesAreSelectable18652;
		 bool java.sql.DatabaseMetaData.allTablesAreSelectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allTablesAreSelectable18652);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allTablesAreSelectable18652);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedHigh18653;
		 bool java.sql.DatabaseMetaData.nullsAreSortedHigh() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh18653);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh18653);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedLow18654;
		 bool java.sql.DatabaseMetaData.nullsAreSortedLow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedLow18654);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedLow18654);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtStart18655;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart18655);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart18655);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtEnd18656;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd18656);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd18656);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductName18657;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductName18657)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductName18657)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductVersion18658;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion18658)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion18658)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverName18659;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverName18659)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverName18659)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverVersion18660;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverVersion18660)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverVersion18660)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMajorVersion18661;
		 int java.sql.DatabaseMetaData.getDriverMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMajorVersion18661);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMajorVersion18661);
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMinorVersion18662;
		 int java.sql.DatabaseMetaData.getDriverMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMinorVersion18662);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMinorVersion18662);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFiles18663;
		 bool java.sql.DatabaseMetaData.usesLocalFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFiles18663);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFiles18663);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFilePerTable18664;
		 bool java.sql.DatabaseMetaData.usesLocalFilePerTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable18664);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable18664);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseIdentifiers18665;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers18665);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers18665);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseIdentifiers18666;
		 bool java.sql.DatabaseMetaData.storesUpperCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers18666);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers18666);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseIdentifiers18667;
		 bool java.sql.DatabaseMetaData.storesLowerCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers18667);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers18667);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseIdentifiers18668;
		 bool java.sql.DatabaseMetaData.storesMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers18668);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers18668);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseQuotedIdentifiers18669;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers18669);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers18669);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseQuotedIdentifiers18670;
		 bool java.sql.DatabaseMetaData.storesUpperCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers18670);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers18670);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseQuotedIdentifiers18671;
		 bool java.sql.DatabaseMetaData.storesLowerCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers18671);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers18671);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseQuotedIdentifiers18672;
		 bool java.sql.DatabaseMetaData.storesMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers18672);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers18672);
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifierQuoteString18673;
		 global::java.lang.String java.sql.DatabaseMetaData.getIdentifierQuoteString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString18673)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString18673)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSQLKeywords18674;
		 global::java.lang.String java.sql.DatabaseMetaData.getSQLKeywords() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLKeywords18674)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLKeywords18674)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericFunctions18675;
		 global::java.lang.String java.sql.DatabaseMetaData.getNumericFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getNumericFunctions18675)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getNumericFunctions18675)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStringFunctions18676;
		 global::java.lang.String java.sql.DatabaseMetaData.getStringFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getStringFunctions18676)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getStringFunctions18676)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemFunctions18677;
		 global::java.lang.String java.sql.DatabaseMetaData.getSystemFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSystemFunctions18677)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSystemFunctions18677)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDateFunctions18678;
		 global::java.lang.String java.sql.DatabaseMetaData.getTimeDateFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTimeDateFunctions18678)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTimeDateFunctions18678)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSearchStringEscape18679;
		 global::java.lang.String java.sql.DatabaseMetaData.getSearchStringEscape() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSearchStringEscape18679)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSearchStringEscape18679)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExtraNameCharacters18680;
		 global::java.lang.String java.sql.DatabaseMetaData.getExtraNameCharacters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExtraNameCharacters18680)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExtraNameCharacters18680)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithAddColumn18681;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithAddColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn18681);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn18681);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithDropColumn18682;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithDropColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn18682);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn18682);
		}
		internal static global::MonoJavaBridge.MethodId _supportsColumnAliasing18683;
		 bool java.sql.DatabaseMetaData.supportsColumnAliasing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsColumnAliasing18683);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsColumnAliasing18683);
		}
		internal static global::MonoJavaBridge.MethodId _nullPlusNonNullIsNull18684;
		 bool java.sql.DatabaseMetaData.nullPlusNonNullIsNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull18684);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull18684);
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert18685;
		 bool java.sql.DatabaseMetaData.supportsConvert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert18685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert18685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert18686;
		 bool java.sql.DatabaseMetaData.supportsConvert() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert18686);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert18686);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTableCorrelationNames18687;
		 bool java.sql.DatabaseMetaData.supportsTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames18687);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames18687);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDifferentTableCorrelationNames18688;
		 bool java.sql.DatabaseMetaData.supportsDifferentTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames18688);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames18688);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExpressionsInOrderBy18689;
		 bool java.sql.DatabaseMetaData.supportsExpressionsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy18689);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy18689);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOrderByUnrelated18690;
		 bool java.sql.DatabaseMetaData.supportsOrderByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated18690);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated18690);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupBy18691;
		 bool java.sql.DatabaseMetaData.supportsGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupBy18691);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupBy18691);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByUnrelated18692;
		 bool java.sql.DatabaseMetaData.supportsGroupByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated18692);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated18692);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByBeyondSelect18693;
		 bool java.sql.DatabaseMetaData.supportsGroupByBeyondSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect18693);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect18693);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLikeEscapeClause18694;
		 bool java.sql.DatabaseMetaData.supportsLikeEscapeClause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause18694);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause18694);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleResultSets18695;
		 bool java.sql.DatabaseMetaData.supportsMultipleResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets18695);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets18695);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleTransactions18696;
		 bool java.sql.DatabaseMetaData.supportsMultipleTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions18696);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions18696);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNonNullableColumns18697;
		 bool java.sql.DatabaseMetaData.supportsNonNullableColumns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns18697);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns18697);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMinimumSQLGrammar18698;
		 bool java.sql.DatabaseMetaData.supportsMinimumSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar18698);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar18698);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCoreSQLGrammar18699;
		 bool java.sql.DatabaseMetaData.supportsCoreSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar18699);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar18699);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExtendedSQLGrammar18700;
		 bool java.sql.DatabaseMetaData.supportsExtendedSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar18700);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar18700);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92EntryLevelSQL18701;
		 bool java.sql.DatabaseMetaData.supportsANSI92EntryLevelSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL18701);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL18701);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92IntermediateSQL18702;
		 bool java.sql.DatabaseMetaData.supportsANSI92IntermediateSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL18702);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL18702);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92FullSQL18703;
		 bool java.sql.DatabaseMetaData.supportsANSI92FullSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL18703);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL18703);
		}
		internal static global::MonoJavaBridge.MethodId _supportsIntegrityEnhancementFacility18704;
		 bool java.sql.DatabaseMetaData.supportsIntegrityEnhancementFacility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility18704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility18704);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOuterJoins18705;
		 bool java.sql.DatabaseMetaData.supportsOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOuterJoins18705);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOuterJoins18705);
		}
		internal static global::MonoJavaBridge.MethodId _supportsFullOuterJoins18706;
		 bool java.sql.DatabaseMetaData.supportsFullOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins18706);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins18706);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLimitedOuterJoins18707;
		 bool java.sql.DatabaseMetaData.supportsLimitedOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins18707);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins18707);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTerm18708;
		 global::java.lang.String java.sql.DatabaseMetaData.getSchemaTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemaTerm18708)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemaTerm18708)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureTerm18709;
		 global::java.lang.String java.sql.DatabaseMetaData.getProcedureTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureTerm18709)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureTerm18709)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogTerm18710;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogTerm18710)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogTerm18710)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCatalogAtStart18711;
		 bool java.sql.DatabaseMetaData.isCatalogAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isCatalogAtStart18711);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isCatalogAtStart18711);
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogSeparator18712;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogSeparator18712)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogSeparator18712)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInDataManipulation18713;
		 bool java.sql.DatabaseMetaData.supportsSchemasInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation18713);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation18713);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInProcedureCalls18714;
		 bool java.sql.DatabaseMetaData.supportsSchemasInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls18714);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls18714);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInTableDefinitions18715;
		 bool java.sql.DatabaseMetaData.supportsSchemasInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions18715);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions18715);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInIndexDefinitions18716;
		 bool java.sql.DatabaseMetaData.supportsSchemasInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions18716);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions18716);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInPrivilegeDefinitions18717;
		 bool java.sql.DatabaseMetaData.supportsSchemasInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions18717);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions18717);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInDataManipulation18718;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation18718);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation18718);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInProcedureCalls18719;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls18719);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls18719);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInTableDefinitions18720;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions18720);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions18720);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInIndexDefinitions18721;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions18721);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions18721);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInPrivilegeDefinitions18722;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions18722);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions18722);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedDelete18723;
		 bool java.sql.DatabaseMetaData.supportsPositionedDelete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedDelete18723);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedDelete18723);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedUpdate18724;
		 bool java.sql.DatabaseMetaData.supportsPositionedUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate18724);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate18724);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSelectForUpdate18725;
		 bool java.sql.DatabaseMetaData.supportsSelectForUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate18725);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate18725);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredProcedures18726;
		 bool java.sql.DatabaseMetaData.supportsStoredProcedures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredProcedures18726);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredProcedures18726);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInComparisons18727;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInComparisons() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons18727);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons18727);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInExists18728;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInExists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists18728);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists18728);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInIns18729;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInIns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns18729);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns18729);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInQuantifieds18730;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInQuantifieds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds18730);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds18730);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCorrelatedSubqueries18731;
		 bool java.sql.DatabaseMetaData.supportsCorrelatedSubqueries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries18731);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries18731);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnion18732;
		 bool java.sql.DatabaseMetaData.supportsUnion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnion18732);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnion18732);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnionAll18733;
		 bool java.sql.DatabaseMetaData.supportsUnionAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnionAll18733);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnionAll18733);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossCommit18734;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit18734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit18734);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossRollback18735;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback18735);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback18735);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossCommit18736;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit18736);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit18736);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossRollback18737;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback18737);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback18737);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxBinaryLiteralLength18738;
		 int java.sql.DatabaseMetaData.getMaxBinaryLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength18738);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength18738);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCharLiteralLength18739;
		 int java.sql.DatabaseMetaData.getMaxCharLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength18739);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength18739);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnNameLength18740;
		 int java.sql.DatabaseMetaData.getMaxColumnNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength18740);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength18740);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInGroupBy18741;
		 int java.sql.DatabaseMetaData.getMaxColumnsInGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy18741);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy18741);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInIndex18742;
		 int java.sql.DatabaseMetaData.getMaxColumnsInIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex18742);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex18742);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInOrderBy18743;
		 int java.sql.DatabaseMetaData.getMaxColumnsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy18743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy18743);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInSelect18744;
		 int java.sql.DatabaseMetaData.getMaxColumnsInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect18744);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect18744);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInTable18745;
		 int java.sql.DatabaseMetaData.getMaxColumnsInTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable18745);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable18745);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnections18746;
		 int java.sql.DatabaseMetaData.getMaxConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxConnections18746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxConnections18746);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCursorNameLength18747;
		 int java.sql.DatabaseMetaData.getMaxCursorNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength18747);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength18747);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxIndexLength18748;
		 int java.sql.DatabaseMetaData.getMaxIndexLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxIndexLength18748);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxIndexLength18748);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSchemaNameLength18749;
		 int java.sql.DatabaseMetaData.getMaxSchemaNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength18749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength18749);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxProcedureNameLength18750;
		 int java.sql.DatabaseMetaData.getMaxProcedureNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength18750);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength18750);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCatalogNameLength18751;
		 int java.sql.DatabaseMetaData.getMaxCatalogNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength18751);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength18751);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRowSize18752;
		 int java.sql.DatabaseMetaData.getMaxRowSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxRowSize18752);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxRowSize18752);
		}
		internal static global::MonoJavaBridge.MethodId _doesMaxRowSizeIncludeBlobs18753;
		 bool java.sql.DatabaseMetaData.doesMaxRowSizeIncludeBlobs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs18753);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs18753);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatementLength18754;
		 int java.sql.DatabaseMetaData.getMaxStatementLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatementLength18754);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatementLength18754);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatements18755;
		 int java.sql.DatabaseMetaData.getMaxStatements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatements18755);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatements18755);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTableNameLength18756;
		 int java.sql.DatabaseMetaData.getMaxTableNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTableNameLength18756);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTableNameLength18756);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTablesInSelect18757;
		 int java.sql.DatabaseMetaData.getMaxTablesInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect18757);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect18757);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxUserNameLength18758;
		 int java.sql.DatabaseMetaData.getMaxUserNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxUserNameLength18758);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxUserNameLength18758);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTransactionIsolation18759;
		 int java.sql.DatabaseMetaData.getDefaultTransactionIsolation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation18759);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation18759);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactions18760;
		 bool java.sql.DatabaseMetaData.supportsTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactions18760);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactions18760);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactionIsolationLevel18761;
		 bool java.sql.DatabaseMetaData.supportsTransactionIsolationLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel18761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel18761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataDefinitionAndDataManipulationTransactions18762;
		 bool java.sql.DatabaseMetaData.supportsDataDefinitionAndDataManipulationTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions18762);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions18762);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataManipulationTransactionsOnly18763;
		 bool java.sql.DatabaseMetaData.supportsDataManipulationTransactionsOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly18763);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly18763);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionCausesTransactionCommit18764;
		 bool java.sql.DatabaseMetaData.dataDefinitionCausesTransactionCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit18764);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit18764);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionIgnoredInTransactions18765;
		 bool java.sql.DatabaseMetaData.dataDefinitionIgnoredInTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions18765);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions18765);
		}
		internal static global::MonoJavaBridge.MethodId _getProcedures18766;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedures18766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedures18766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureColumns18767;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureColumns18767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureColumns18767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas18768;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas18768)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas18768)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas18769;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas18769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas18769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogs18770;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCatalogs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogs18770)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogs18770)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTableTypes18771;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTableTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTableTypes18771)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTableTypes18771)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumns18772;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumns18772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumns18772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnPrivileges18773;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumnPrivileges18773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumnPrivileges18773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTablePrivileges18774;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTablePrivileges18774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTablePrivileges18774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getBestRowIdentifier18775;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getBestRowIdentifier18775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getBestRowIdentifier18775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionColumns18776;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getVersionColumns18776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getVersionColumns18776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimaryKeys18777;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getPrimaryKeys18777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getPrimaryKeys18777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getImportedKeys18778;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getImportedKeys18778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getImportedKeys18778, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getExportedKeys18779;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExportedKeys18779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExportedKeys18779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCrossReference18780;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCrossReference18780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCrossReference18780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfo18781;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTypeInfo18781)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTypeInfo18781)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getIndexInfo18782;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIndexInfo18782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIndexInfo18782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetType18783;
		 bool java.sql.DatabaseMetaData.supportsResultSetType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetType18783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetType18783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetConcurrency18784;
		 bool java.sql.DatabaseMetaData.supportsResultSetConcurrency(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency18784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency18784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ownUpdatesAreVisible18785;
		 bool java.sql.DatabaseMetaData.ownUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible18785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownDeletesAreVisible18786;
		 bool java.sql.DatabaseMetaData.ownDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible18786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible18786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownInsertsAreVisible18787;
		 bool java.sql.DatabaseMetaData.ownInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible18787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible18787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersUpdatesAreVisible18788;
		 bool java.sql.DatabaseMetaData.othersUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible18788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersDeletesAreVisible18789;
		 bool java.sql.DatabaseMetaData.othersDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible18789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible18789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersInsertsAreVisible18790;
		 bool java.sql.DatabaseMetaData.othersInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible18790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible18790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updatesAreDetected18791;
		 bool java.sql.DatabaseMetaData.updatesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._updatesAreDetected18791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._updatesAreDetected18791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deletesAreDetected18792;
		 bool java.sql.DatabaseMetaData.deletesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._deletesAreDetected18792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._deletesAreDetected18792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertsAreDetected18793;
		 bool java.sql.DatabaseMetaData.insertsAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._insertsAreDetected18793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._insertsAreDetected18793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsBatchUpdates18794;
		 bool java.sql.DatabaseMetaData.supportsBatchUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsBatchUpdates18794);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsBatchUpdates18794);
		}
		internal static global::MonoJavaBridge.MethodId _getUDTs18795;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUDTs18795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUDTs18795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSavepoints18796;
		 bool java.sql.DatabaseMetaData.supportsSavepoints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSavepoints18796);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSavepoints18796);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNamedParameters18797;
		 bool java.sql.DatabaseMetaData.supportsNamedParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNamedParameters18797);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNamedParameters18797);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleOpenResults18798;
		 bool java.sql.DatabaseMetaData.supportsMultipleOpenResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults18798);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults18798);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGetGeneratedKeys18799;
		 bool java.sql.DatabaseMetaData.supportsGetGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys18799);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys18799);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTypes18800;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTypes18800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTypes18800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTables18801;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTables18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTables18801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetHoldability18802;
		 bool java.sql.DatabaseMetaData.supportsResultSetHoldability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability18802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability18802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMajorVersion18803;
		 int java.sql.DatabaseMetaData.getDatabaseMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion18803);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion18803);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMinorVersion18804;
		 int java.sql.DatabaseMetaData.getDatabaseMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion18804);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion18804);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMajorVersion18805;
		 int java.sql.DatabaseMetaData.getJDBCMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion18805);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion18805);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMinorVersion18806;
		 int java.sql.DatabaseMetaData.getJDBCMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion18806);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion18806);
		}
		internal static global::MonoJavaBridge.MethodId _getSQLStateType18807;
		 int java.sql.DatabaseMetaData.getSQLStateType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLStateType18807);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLStateType18807);
		}
		internal static global::MonoJavaBridge.MethodId _locatorsUpdateCopy18808;
		 bool java.sql.DatabaseMetaData.locatorsUpdateCopy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy18808);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy18808);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStatementPooling18809;
		 bool java.sql.DatabaseMetaData.supportsStatementPooling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStatementPooling18809);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStatementPooling18809);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredFunctionsUsingCallSyntax18810;
		 bool java.sql.DatabaseMetaData.supportsStoredFunctionsUsingCallSyntax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax18810);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax18810);
		}
		internal static global::MonoJavaBridge.MethodId _autoCommitFailureClosesAllResultSets18811;
		 bool java.sql.DatabaseMetaData.autoCommitFailureClosesAllResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets18811);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets18811);
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfoProperties18812;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getClientInfoProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getClientInfoProperties18812)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getClientInfoProperties18812)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctions18813;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctions18813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctions18813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctionColumns18814;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctionColumns18814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctionColumns18814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DatabaseMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DatabaseMetaData"));
			global::java.sql.DatabaseMetaData_._getURL18644 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getURL", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isReadOnly18645 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isReadOnly", "()Z");
			global::java.sql.DatabaseMetaData_._getAttributes18646 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTables18647 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getConnection18648 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.DatabaseMetaData_._getUserName18649 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUserName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getResultSetHoldability18650 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.DatabaseMetaData_._allProceduresAreCallable18651 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allProceduresAreCallable", "()Z");
			global::java.sql.DatabaseMetaData_._allTablesAreSelectable18652 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allTablesAreSelectable", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedHigh18653 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedHigh", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedLow18654 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedLow", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart18655 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd18656 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtEnd", "()Z");
			global::java.sql.DatabaseMetaData_._getDatabaseProductName18657 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDatabaseProductVersion18658 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverName18659 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverVersion18660 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverMajorVersion18661 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDriverMinorVersion18662 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._usesLocalFiles18663 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFiles", "()Z");
			global::java.sql.DatabaseMetaData_._usesLocalFilePerTable18664 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFilePerTable", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers18665 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers18666 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers18667 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers18668 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers18669 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers18670 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers18671 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers18672 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._getIdentifierQuoteString18673 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIdentifierQuoteString", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSQLKeywords18674 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLKeywords", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getNumericFunctions18675 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getNumericFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getStringFunctions18676 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getStringFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSystemFunctions18677 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSystemFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getTimeDateFunctions18678 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTimeDateFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSearchStringEscape18679 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSearchStringEscape", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getExtraNameCharacters18680 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExtraNameCharacters", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn18681 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithAddColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn18682 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithDropColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsColumnAliasing18683 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsColumnAliasing", "()Z");
			global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull18684 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullPlusNonNullIsNull", "()Z");
			global::java.sql.DatabaseMetaData_._supportsConvert18685 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "(II)Z");
			global::java.sql.DatabaseMetaData_._supportsConvert18686 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames18687 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames18688 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDifferentTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy18689 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExpressionsInOrderBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated18690 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOrderByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupBy18691 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated18692 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect18693 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByBeyondSelect", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause18694 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLikeEscapeClause", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleResultSets18695 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleTransactions18696 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNonNullableColumns18697 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNonNullableColumns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar18698 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMinimumSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar18699 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCoreSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar18700 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExtendedSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL18701 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92EntryLevelSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL18702 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92IntermediateSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL18703 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92FullSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility18704 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsIntegrityEnhancementFacility", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOuterJoins18705 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsFullOuterJoins18706 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsFullOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins18707 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLimitedOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._getSchemaTerm18708 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemaTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getProcedureTerm18709 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getCatalogTerm18710 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isCatalogAtStart18711 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isCatalogAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._getCatalogSeparator18712 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogSeparator", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation18713 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls18714 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions18715 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions18716 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions18717 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation18718 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls18719 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions18720 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions18721 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions18722 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedDelete18723 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedDelete", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedUpdate18724 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSelectForUpdate18725 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSelectForUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredProcedures18726 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredProcedures", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons18727 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInComparisons", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists18728 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInExists", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns18729 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInIns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds18730 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInQuantifieds", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries18731 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCorrelatedSubqueries", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnion18732 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnion", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnionAll18733 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnionAll", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit18734 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback18735 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit18736 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback18737 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength18738 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxBinaryLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength18739 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCharLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnNameLength18740 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy18741 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInGroupBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex18742 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInIndex", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy18743 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInOrderBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect18744 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInTable18745 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInTable", "()I");
			global::java.sql.DatabaseMetaData_._getMaxConnections18746 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxConnections", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCursorNameLength18747 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCursorNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxIndexLength18748 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxIndexLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength18749 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxSchemaNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength18750 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxProcedureNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength18751 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCatalogNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxRowSize18752 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxRowSize", "()I");
			global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs18753 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "doesMaxRowSizeIncludeBlobs", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxStatementLength18754 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatementLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxStatements18755 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatements", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTableNameLength18756 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTableNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTablesInSelect18757 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTablesInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxUserNameLength18758 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxUserNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation18759 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDefaultTransactionIsolation", "()I");
			global::java.sql.DatabaseMetaData_._supportsTransactions18760 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel18761 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactionIsolationLevel", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions18762 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataDefinitionAndDataManipulationTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly18763 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataManipulationTransactionsOnly", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit18764 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionCausesTransactionCommit", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions18765 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionIgnoredInTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._getProcedures18766 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getProcedureColumns18767 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas18768 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas18769 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCatalogs18770 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogs", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTableTypes18771 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTableTypes", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumns18772 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumnPrivileges18773 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTablePrivileges18774 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getBestRowIdentifier18775 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getVersionColumns18776 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getPrimaryKeys18777 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getImportedKeys18778 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getExportedKeys18779 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCrossReference18780 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTypeInfo18781 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTypeInfo", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getIndexInfo18782 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetType18783 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetType", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency18784 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetConcurrency", "(II)Z");
			global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible18785 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownDeletesAreVisible18786 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownInsertsAreVisible18787 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible18788 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersDeletesAreVisible18789 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersInsertsAreVisible18790 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._updatesAreDetected18791 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "updatesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._deletesAreDetected18792 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "deletesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._insertsAreDetected18793 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "insertsAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsBatchUpdates18794 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsBatchUpdates", "()Z");
			global::java.sql.DatabaseMetaData_._getUDTs18795 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsSavepoints18796 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSavepoints", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNamedParameters18797 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNamedParameters", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults18798 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleOpenResults", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys18799 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGetGeneratedKeys", "()Z");
			global::java.sql.DatabaseMetaData_._getSuperTypes18800 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSuperTables18801 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetHoldability18802 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetHoldability", "(I)Z");
			global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion18803 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion18804 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMajorVersion18805 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMinorVersion18806 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getSQLStateType18807 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLStateType", "()I");
			global::java.sql.DatabaseMetaData_._locatorsUpdateCopy18808 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "locatorsUpdateCopy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStatementPooling18809 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStatementPooling", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax18810 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredFunctionsUsingCallSyntax", "()Z");
			global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets18811 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "autoCommitFailureClosesAllResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._getClientInfoProperties18812 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getClientInfoProperties", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctions18813 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctionColumns18814 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
		}
	}
}
