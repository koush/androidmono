namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.DatabaseMetaData_))]
	public partial interface DatabaseMetaData  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class DatabaseMetaData_ : java.lang.Object, DatabaseMetaData
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatabaseMetaData_()
		{
			InitJNI();
		}
		internal DatabaseMetaData_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getURL24376;
		 global::java.lang.String java.sql.DatabaseMetaData.getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getURL24376)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getURL24376)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24377;
		 bool java.sql.DatabaseMetaData.isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isReadOnly24377);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isReadOnly24377);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes24378;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getAttributes24378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getAttributes24378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTables24379;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTables24379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTables24379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24380;
		 global::java.sql.Connection java.sql.DatabaseMetaData.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getConnection24380)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getConnection24380)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getUserName24381;
		 global::java.lang.String java.sql.DatabaseMetaData.getUserName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUserName24381)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUserName24381)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24382;
		 int java.sql.DatabaseMetaData.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getResultSetHoldability24382);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getResultSetHoldability24382);
		}
		internal static global::MonoJavaBridge.MethodId _allProceduresAreCallable24383;
		 bool java.sql.DatabaseMetaData.allProceduresAreCallable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allProceduresAreCallable24383);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allProceduresAreCallable24383);
		}
		internal static global::MonoJavaBridge.MethodId _allTablesAreSelectable24384;
		 bool java.sql.DatabaseMetaData.allTablesAreSelectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allTablesAreSelectable24384);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allTablesAreSelectable24384);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedHigh24385;
		 bool java.sql.DatabaseMetaData.nullsAreSortedHigh() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24385);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24385);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedLow24386;
		 bool java.sql.DatabaseMetaData.nullsAreSortedLow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedLow24386);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedLow24386);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtStart24387;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24387);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24387);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtEnd24388;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24388);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24388);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductName24389;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductName24389)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductName24389)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductVersion24390;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24390)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24390)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverName24391;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverName24391)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverName24391)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverVersion24392;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverVersion24392)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverVersion24392)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMajorVersion24393;
		 int java.sql.DatabaseMetaData.getDriverMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMajorVersion24393);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMajorVersion24393);
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMinorVersion24394;
		 int java.sql.DatabaseMetaData.getDriverMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMinorVersion24394);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMinorVersion24394);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFiles24395;
		 bool java.sql.DatabaseMetaData.usesLocalFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFiles24395);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFiles24395);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFilePerTable24396;
		 bool java.sql.DatabaseMetaData.usesLocalFilePerTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24396);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24396);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseIdentifiers24397;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24397);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24397);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseIdentifiers24398;
		 bool java.sql.DatabaseMetaData.storesUpperCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24398);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24398);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseIdentifiers24399;
		 bool java.sql.DatabaseMetaData.storesLowerCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24399);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24399);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseIdentifiers24400;
		 bool java.sql.DatabaseMetaData.storesMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24400);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24400);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseQuotedIdentifiers24401;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24401);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24401);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseQuotedIdentifiers24402;
		 bool java.sql.DatabaseMetaData.storesUpperCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24402);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24402);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseQuotedIdentifiers24403;
		 bool java.sql.DatabaseMetaData.storesLowerCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24403);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24403);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseQuotedIdentifiers24404;
		 bool java.sql.DatabaseMetaData.storesMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24404);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24404);
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifierQuoteString24405;
		 global::java.lang.String java.sql.DatabaseMetaData.getIdentifierQuoteString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24405)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24405)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSQLKeywords24406;
		 global::java.lang.String java.sql.DatabaseMetaData.getSQLKeywords() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLKeywords24406)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLKeywords24406)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericFunctions24407;
		 global::java.lang.String java.sql.DatabaseMetaData.getNumericFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getNumericFunctions24407)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getNumericFunctions24407)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStringFunctions24408;
		 global::java.lang.String java.sql.DatabaseMetaData.getStringFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getStringFunctions24408)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getStringFunctions24408)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemFunctions24409;
		 global::java.lang.String java.sql.DatabaseMetaData.getSystemFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSystemFunctions24409)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSystemFunctions24409)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDateFunctions24410;
		 global::java.lang.String java.sql.DatabaseMetaData.getTimeDateFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTimeDateFunctions24410)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTimeDateFunctions24410)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSearchStringEscape24411;
		 global::java.lang.String java.sql.DatabaseMetaData.getSearchStringEscape() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSearchStringEscape24411)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSearchStringEscape24411)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExtraNameCharacters24412;
		 global::java.lang.String java.sql.DatabaseMetaData.getExtraNameCharacters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExtraNameCharacters24412)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExtraNameCharacters24412)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithAddColumn24413;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithAddColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24413);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithDropColumn24414;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithDropColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24414);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24414);
		}
		internal static global::MonoJavaBridge.MethodId _supportsColumnAliasing24415;
		 bool java.sql.DatabaseMetaData.supportsColumnAliasing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsColumnAliasing24415);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsColumnAliasing24415);
		}
		internal static global::MonoJavaBridge.MethodId _nullPlusNonNullIsNull24416;
		 bool java.sql.DatabaseMetaData.nullPlusNonNullIsNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24416);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24416);
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24417;
		 bool java.sql.DatabaseMetaData.supportsConvert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert24417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert24417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24418;
		 bool java.sql.DatabaseMetaData.supportsConvert() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert24418);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert24418);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTableCorrelationNames24419;
		 bool java.sql.DatabaseMetaData.supportsTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24419);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24419);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDifferentTableCorrelationNames24420;
		 bool java.sql.DatabaseMetaData.supportsDifferentTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24420);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24420);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExpressionsInOrderBy24421;
		 bool java.sql.DatabaseMetaData.supportsExpressionsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24421);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24421);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOrderByUnrelated24422;
		 bool java.sql.DatabaseMetaData.supportsOrderByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24422);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupBy24423;
		 bool java.sql.DatabaseMetaData.supportsGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupBy24423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupBy24423);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByUnrelated24424;
		 bool java.sql.DatabaseMetaData.supportsGroupByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24424);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24424);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByBeyondSelect24425;
		 bool java.sql.DatabaseMetaData.supportsGroupByBeyondSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24425);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24425);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLikeEscapeClause24426;
		 bool java.sql.DatabaseMetaData.supportsLikeEscapeClause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24426);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24426);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleResultSets24427;
		 bool java.sql.DatabaseMetaData.supportsMultipleResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24427);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24427);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleTransactions24428;
		 bool java.sql.DatabaseMetaData.supportsMultipleTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24428);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24428);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNonNullableColumns24429;
		 bool java.sql.DatabaseMetaData.supportsNonNullableColumns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24429);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24429);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMinimumSQLGrammar24430;
		 bool java.sql.DatabaseMetaData.supportsMinimumSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24430);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24430);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCoreSQLGrammar24431;
		 bool java.sql.DatabaseMetaData.supportsCoreSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24431);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24431);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExtendedSQLGrammar24432;
		 bool java.sql.DatabaseMetaData.supportsExtendedSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24432);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24432);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92EntryLevelSQL24433;
		 bool java.sql.DatabaseMetaData.supportsANSI92EntryLevelSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24433);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92IntermediateSQL24434;
		 bool java.sql.DatabaseMetaData.supportsANSI92IntermediateSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24434);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24434);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92FullSQL24435;
		 bool java.sql.DatabaseMetaData.supportsANSI92FullSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24435);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24435);
		}
		internal static global::MonoJavaBridge.MethodId _supportsIntegrityEnhancementFacility24436;
		 bool java.sql.DatabaseMetaData.supportsIntegrityEnhancementFacility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24436);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24436);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOuterJoins24437;
		 bool java.sql.DatabaseMetaData.supportsOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOuterJoins24437);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOuterJoins24437);
		}
		internal static global::MonoJavaBridge.MethodId _supportsFullOuterJoins24438;
		 bool java.sql.DatabaseMetaData.supportsFullOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24438);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24438);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLimitedOuterJoins24439;
		 bool java.sql.DatabaseMetaData.supportsLimitedOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24439);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24439);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTerm24440;
		 global::java.lang.String java.sql.DatabaseMetaData.getSchemaTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemaTerm24440)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemaTerm24440)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureTerm24441;
		 global::java.lang.String java.sql.DatabaseMetaData.getProcedureTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureTerm24441)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureTerm24441)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogTerm24442;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogTerm24442)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogTerm24442)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCatalogAtStart24443;
		 bool java.sql.DatabaseMetaData.isCatalogAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isCatalogAtStart24443);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isCatalogAtStart24443);
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogSeparator24444;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogSeparator24444)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogSeparator24444)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInDataManipulation24445;
		 bool java.sql.DatabaseMetaData.supportsSchemasInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24445);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24445);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInProcedureCalls24446;
		 bool java.sql.DatabaseMetaData.supportsSchemasInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24446);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24446);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInTableDefinitions24447;
		 bool java.sql.DatabaseMetaData.supportsSchemasInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24447);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24447);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInIndexDefinitions24448;
		 bool java.sql.DatabaseMetaData.supportsSchemasInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24448);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24448);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInPrivilegeDefinitions24449;
		 bool java.sql.DatabaseMetaData.supportsSchemasInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24449);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24449);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInDataManipulation24450;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24450);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24450);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInProcedureCalls24451;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24451);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24451);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInTableDefinitions24452;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24452);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInIndexDefinitions24453;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24453);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24453);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInPrivilegeDefinitions24454;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24454);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24454);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedDelete24455;
		 bool java.sql.DatabaseMetaData.supportsPositionedDelete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedDelete24455);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedDelete24455);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedUpdate24456;
		 bool java.sql.DatabaseMetaData.supportsPositionedUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24456);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24456);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSelectForUpdate24457;
		 bool java.sql.DatabaseMetaData.supportsSelectForUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24457);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24457);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredProcedures24458;
		 bool java.sql.DatabaseMetaData.supportsStoredProcedures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredProcedures24458);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredProcedures24458);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInComparisons24459;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInComparisons() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24459);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24459);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInExists24460;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInExists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24460);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24460);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInIns24461;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInIns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24461);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24461);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInQuantifieds24462;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInQuantifieds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24462);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24462);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCorrelatedSubqueries24463;
		 bool java.sql.DatabaseMetaData.supportsCorrelatedSubqueries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24463);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24463);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnion24464;
		 bool java.sql.DatabaseMetaData.supportsUnion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnion24464);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnion24464);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnionAll24465;
		 bool java.sql.DatabaseMetaData.supportsUnionAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnionAll24465);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnionAll24465);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossCommit24466;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24466);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24466);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossRollback24467;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24467);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24467);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossCommit24468;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24468);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossRollback24469;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24469);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24469);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxBinaryLiteralLength24470;
		 int java.sql.DatabaseMetaData.getMaxBinaryLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24470);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24470);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCharLiteralLength24471;
		 int java.sql.DatabaseMetaData.getMaxCharLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24471);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24471);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnNameLength24472;
		 int java.sql.DatabaseMetaData.getMaxColumnNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24472);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24472);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInGroupBy24473;
		 int java.sql.DatabaseMetaData.getMaxColumnsInGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24473);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24473);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInIndex24474;
		 int java.sql.DatabaseMetaData.getMaxColumnsInIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24474);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24474);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInOrderBy24475;
		 int java.sql.DatabaseMetaData.getMaxColumnsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24475);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24475);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInSelect24476;
		 int java.sql.DatabaseMetaData.getMaxColumnsInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24476);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24476);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInTable24477;
		 int java.sql.DatabaseMetaData.getMaxColumnsInTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24477);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24477);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnections24478;
		 int java.sql.DatabaseMetaData.getMaxConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxConnections24478);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxConnections24478);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCursorNameLength24479;
		 int java.sql.DatabaseMetaData.getMaxCursorNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24479);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24479);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxIndexLength24480;
		 int java.sql.DatabaseMetaData.getMaxIndexLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxIndexLength24480);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxIndexLength24480);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSchemaNameLength24481;
		 int java.sql.DatabaseMetaData.getMaxSchemaNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24481);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24481);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxProcedureNameLength24482;
		 int java.sql.DatabaseMetaData.getMaxProcedureNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24482);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24482);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCatalogNameLength24483;
		 int java.sql.DatabaseMetaData.getMaxCatalogNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24483);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24483);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRowSize24484;
		 int java.sql.DatabaseMetaData.getMaxRowSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxRowSize24484);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxRowSize24484);
		}
		internal static global::MonoJavaBridge.MethodId _doesMaxRowSizeIncludeBlobs24485;
		 bool java.sql.DatabaseMetaData.doesMaxRowSizeIncludeBlobs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24485);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatementLength24486;
		 int java.sql.DatabaseMetaData.getMaxStatementLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatementLength24486);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatementLength24486);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatements24487;
		 int java.sql.DatabaseMetaData.getMaxStatements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatements24487);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatements24487);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTableNameLength24488;
		 int java.sql.DatabaseMetaData.getMaxTableNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTableNameLength24488);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTableNameLength24488);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTablesInSelect24489;
		 int java.sql.DatabaseMetaData.getMaxTablesInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24489);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24489);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxUserNameLength24490;
		 int java.sql.DatabaseMetaData.getMaxUserNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxUserNameLength24490);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxUserNameLength24490);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTransactionIsolation24491;
		 int java.sql.DatabaseMetaData.getDefaultTransactionIsolation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24491);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24491);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactions24492;
		 bool java.sql.DatabaseMetaData.supportsTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactions24492);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactions24492);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactionIsolationLevel24493;
		 bool java.sql.DatabaseMetaData.supportsTransactionIsolationLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataDefinitionAndDataManipulationTransactions24494;
		 bool java.sql.DatabaseMetaData.supportsDataDefinitionAndDataManipulationTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24494);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24494);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataManipulationTransactionsOnly24495;
		 bool java.sql.DatabaseMetaData.supportsDataManipulationTransactionsOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24495);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24495);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionCausesTransactionCommit24496;
		 bool java.sql.DatabaseMetaData.dataDefinitionCausesTransactionCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24496);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24496);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionIgnoredInTransactions24497;
		 bool java.sql.DatabaseMetaData.dataDefinitionIgnoredInTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24497);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24497);
		}
		internal static global::MonoJavaBridge.MethodId _getProcedures24498;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedures24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedures24498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureColumns24499;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureColumns24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureColumns24499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24500;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas24500)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas24500)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24501;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas24501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogs24502;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCatalogs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogs24502)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogs24502)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTableTypes24503;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTableTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTableTypes24503)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTableTypes24503)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumns24504;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumns24504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumns24504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnPrivileges24505;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumnPrivileges24505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumnPrivileges24505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTablePrivileges24506;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTablePrivileges24506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTablePrivileges24506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getBestRowIdentifier24507;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getBestRowIdentifier24507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getBestRowIdentifier24507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionColumns24508;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getVersionColumns24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getVersionColumns24508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimaryKeys24509;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getPrimaryKeys24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getPrimaryKeys24509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getImportedKeys24510;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getImportedKeys24510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getImportedKeys24510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getExportedKeys24511;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExportedKeys24511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExportedKeys24511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCrossReference24512;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCrossReference24512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCrossReference24512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfo24513;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTypeInfo24513)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTypeInfo24513)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getIndexInfo24514;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIndexInfo24514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIndexInfo24514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetType24515;
		 bool java.sql.DatabaseMetaData.supportsResultSetType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetType24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetType24515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetConcurrency24516;
		 bool java.sql.DatabaseMetaData.supportsResultSetConcurrency(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ownUpdatesAreVisible24517;
		 bool java.sql.DatabaseMetaData.ownUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownDeletesAreVisible24518;
		 bool java.sql.DatabaseMetaData.ownDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownInsertsAreVisible24519;
		 bool java.sql.DatabaseMetaData.ownInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersUpdatesAreVisible24520;
		 bool java.sql.DatabaseMetaData.othersUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersDeletesAreVisible24521;
		 bool java.sql.DatabaseMetaData.othersDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersInsertsAreVisible24522;
		 bool java.sql.DatabaseMetaData.othersInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updatesAreDetected24523;
		 bool java.sql.DatabaseMetaData.updatesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._updatesAreDetected24523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._updatesAreDetected24523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deletesAreDetected24524;
		 bool java.sql.DatabaseMetaData.deletesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._deletesAreDetected24524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._deletesAreDetected24524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertsAreDetected24525;
		 bool java.sql.DatabaseMetaData.insertsAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._insertsAreDetected24525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._insertsAreDetected24525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsBatchUpdates24526;
		 bool java.sql.DatabaseMetaData.supportsBatchUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsBatchUpdates24526);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsBatchUpdates24526);
		}
		internal static global::MonoJavaBridge.MethodId _getUDTs24527;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUDTs24527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUDTs24527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSavepoints24528;
		 bool java.sql.DatabaseMetaData.supportsSavepoints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSavepoints24528);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSavepoints24528);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNamedParameters24529;
		 bool java.sql.DatabaseMetaData.supportsNamedParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNamedParameters24529);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNamedParameters24529);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleOpenResults24530;
		 bool java.sql.DatabaseMetaData.supportsMultipleOpenResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24530);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24530);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGetGeneratedKeys24531;
		 bool java.sql.DatabaseMetaData.supportsGetGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24531);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24531);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTypes24532;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTypes24532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTypes24532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTables24533;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTables24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTables24533, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetHoldability24534;
		 bool java.sql.DatabaseMetaData.supportsResultSetHoldability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMajorVersion24535;
		 int java.sql.DatabaseMetaData.getDatabaseMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24535);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24535);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMinorVersion24536;
		 int java.sql.DatabaseMetaData.getDatabaseMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24536);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24536);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMajorVersion24537;
		 int java.sql.DatabaseMetaData.getJDBCMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24537);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24537);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMinorVersion24538;
		 int java.sql.DatabaseMetaData.getJDBCMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24538);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24538);
		}
		internal static global::MonoJavaBridge.MethodId _getSQLStateType24539;
		 int java.sql.DatabaseMetaData.getSQLStateType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLStateType24539);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLStateType24539);
		}
		internal static global::MonoJavaBridge.MethodId _locatorsUpdateCopy24540;
		 bool java.sql.DatabaseMetaData.locatorsUpdateCopy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24540);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStatementPooling24541;
		 bool java.sql.DatabaseMetaData.supportsStatementPooling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStatementPooling24541);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStatementPooling24541);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredFunctionsUsingCallSyntax24542;
		 bool java.sql.DatabaseMetaData.supportsStoredFunctionsUsingCallSyntax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24542);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24542);
		}
		internal static global::MonoJavaBridge.MethodId _autoCommitFailureClosesAllResultSets24543;
		 bool java.sql.DatabaseMetaData.autoCommitFailureClosesAllResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24543);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24543);
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfoProperties24544;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getClientInfoProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getClientInfoProperties24544)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getClientInfoProperties24544)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctions24545;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctions24545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctions24545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctionColumns24546;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctionColumns24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctionColumns24546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DatabaseMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DatabaseMetaData"));
			global::java.sql.DatabaseMetaData_._getURL24376 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getURL", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isReadOnly24377 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isReadOnly", "()Z");
			global::java.sql.DatabaseMetaData_._getAttributes24378 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTables24379 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getConnection24380 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.DatabaseMetaData_._getUserName24381 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUserName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getResultSetHoldability24382 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.DatabaseMetaData_._allProceduresAreCallable24383 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allProceduresAreCallable", "()Z");
			global::java.sql.DatabaseMetaData_._allTablesAreSelectable24384 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allTablesAreSelectable", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24385 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedHigh", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedLow24386 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedLow", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24387 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24388 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtEnd", "()Z");
			global::java.sql.DatabaseMetaData_._getDatabaseProductName24389 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24390 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverName24391 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverVersion24392 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverMajorVersion24393 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDriverMinorVersion24394 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._usesLocalFiles24395 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFiles", "()Z");
			global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24396 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFilePerTable", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24397 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24398 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24399 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24400 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24401 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24402 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24403 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24404 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24405 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIdentifierQuoteString", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSQLKeywords24406 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLKeywords", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getNumericFunctions24407 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getNumericFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getStringFunctions24408 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getStringFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSystemFunctions24409 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSystemFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getTimeDateFunctions24410 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTimeDateFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSearchStringEscape24411 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSearchStringEscape", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getExtraNameCharacters24412 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExtraNameCharacters", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24413 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithAddColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24414 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithDropColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsColumnAliasing24415 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsColumnAliasing", "()Z");
			global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24416 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullPlusNonNullIsNull", "()Z");
			global::java.sql.DatabaseMetaData_._supportsConvert24417 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "(II)Z");
			global::java.sql.DatabaseMetaData_._supportsConvert24418 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24419 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24420 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDifferentTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24421 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExpressionsInOrderBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24422 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOrderByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupBy24423 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24424 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24425 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByBeyondSelect", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24426 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLikeEscapeClause", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24427 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24428 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24429 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNonNullableColumns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24430 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMinimumSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24431 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCoreSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24432 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExtendedSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24433 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92EntryLevelSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24434 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92IntermediateSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24435 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92FullSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24436 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsIntegrityEnhancementFacility", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOuterJoins24437 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24438 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsFullOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24439 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLimitedOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._getSchemaTerm24440 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemaTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getProcedureTerm24441 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getCatalogTerm24442 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isCatalogAtStart24443 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isCatalogAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._getCatalogSeparator24444 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogSeparator", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24445 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24446 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24447 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24448 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24449 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24450 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24451 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24452 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24453 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24454 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedDelete24455 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedDelete", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24456 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24457 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSelectForUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredProcedures24458 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredProcedures", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24459 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInComparisons", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24460 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInExists", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24461 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInIns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24462 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInQuantifieds", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24463 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCorrelatedSubqueries", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnion24464 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnion", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnionAll24465 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnionAll", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24466 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24467 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24468 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24469 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24470 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxBinaryLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24471 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCharLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24472 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24473 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInGroupBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24474 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInIndex", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24475 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInOrderBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24476 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24477 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInTable", "()I");
			global::java.sql.DatabaseMetaData_._getMaxConnections24478 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxConnections", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24479 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCursorNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxIndexLength24480 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxIndexLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24481 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxSchemaNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24482 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxProcedureNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24483 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCatalogNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxRowSize24484 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxRowSize", "()I");
			global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24485 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "doesMaxRowSizeIncludeBlobs", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxStatementLength24486 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatementLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxStatements24487 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatements", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTableNameLength24488 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTableNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24489 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTablesInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxUserNameLength24490 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxUserNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24491 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDefaultTransactionIsolation", "()I");
			global::java.sql.DatabaseMetaData_._supportsTransactions24492 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24493 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactionIsolationLevel", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24494 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataDefinitionAndDataManipulationTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24495 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataManipulationTransactionsOnly", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24496 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionCausesTransactionCommit", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24497 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionIgnoredInTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._getProcedures24498 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getProcedureColumns24499 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas24500 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas24501 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCatalogs24502 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogs", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTableTypes24503 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTableTypes", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumns24504 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumnPrivileges24505 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTablePrivileges24506 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getBestRowIdentifier24507 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getVersionColumns24508 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getPrimaryKeys24509 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getImportedKeys24510 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getExportedKeys24511 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCrossReference24512 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTypeInfo24513 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTypeInfo", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getIndexInfo24514 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetType24515 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetType", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24516 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetConcurrency", "(II)Z");
			global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24517 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24518 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24519 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24520 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24521 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24522 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._updatesAreDetected24523 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "updatesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._deletesAreDetected24524 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "deletesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._insertsAreDetected24525 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "insertsAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsBatchUpdates24526 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsBatchUpdates", "()Z");
			global::java.sql.DatabaseMetaData_._getUDTs24527 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsSavepoints24528 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSavepoints", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNamedParameters24529 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNamedParameters", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24530 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleOpenResults", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24531 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGetGeneratedKeys", "()Z");
			global::java.sql.DatabaseMetaData_._getSuperTypes24532 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSuperTables24533 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24534 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetHoldability", "(I)Z");
			global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24535 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24536 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24537 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24538 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getSQLStateType24539 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLStateType", "()I");
			global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24540 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "locatorsUpdateCopy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStatementPooling24541 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStatementPooling", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24542 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredFunctionsUsingCallSyntax", "()Z");
			global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24543 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "autoCommitFailureClosesAllResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._getClientInfoProperties24544 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getClientInfoProperties", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctions24545 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctionColumns24546 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
		}
	}
}
