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
		internal static global::MonoJavaBridge.MethodId _getURL24258;
		 global::java.lang.String java.sql.DatabaseMetaData.getURL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getURL24258)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getURL24258)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24259;
		 bool java.sql.DatabaseMetaData.isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isReadOnly24259);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isReadOnly24259);
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes24260;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getAttributes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getAttributes24260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getAttributes24260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTables24261;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTables24261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTables24261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24262;
		 global::java.sql.Connection java.sql.DatabaseMetaData.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getConnection24262)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getConnection24262)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getUserName24263;
		 global::java.lang.String java.sql.DatabaseMetaData.getUserName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUserName24263)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUserName24263)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24264;
		 int java.sql.DatabaseMetaData.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getResultSetHoldability24264);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getResultSetHoldability24264);
		}
		internal static global::MonoJavaBridge.MethodId _allProceduresAreCallable24265;
		 bool java.sql.DatabaseMetaData.allProceduresAreCallable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allProceduresAreCallable24265);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allProceduresAreCallable24265);
		}
		internal static global::MonoJavaBridge.MethodId _allTablesAreSelectable24266;
		 bool java.sql.DatabaseMetaData.allTablesAreSelectable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._allTablesAreSelectable24266);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._allTablesAreSelectable24266);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedHigh24267;
		 bool java.sql.DatabaseMetaData.nullsAreSortedHigh() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24267);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24267);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedLow24268;
		 bool java.sql.DatabaseMetaData.nullsAreSortedLow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedLow24268);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedLow24268);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtStart24269;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24269);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24269);
		}
		internal static global::MonoJavaBridge.MethodId _nullsAreSortedAtEnd24270;
		 bool java.sql.DatabaseMetaData.nullsAreSortedAtEnd() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24270);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24270);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductName24271;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductName24271)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductName24271)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseProductVersion24272;
		 global::java.lang.String java.sql.DatabaseMetaData.getDatabaseProductVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverName24273;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverName24273)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverName24273)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverVersion24274;
		 global::java.lang.String java.sql.DatabaseMetaData.getDriverVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverVersion24274)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverVersion24274)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMajorVersion24275;
		 int java.sql.DatabaseMetaData.getDriverMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMajorVersion24275);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMajorVersion24275);
		}
		internal static global::MonoJavaBridge.MethodId _getDriverMinorVersion24276;
		 int java.sql.DatabaseMetaData.getDriverMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDriverMinorVersion24276);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDriverMinorVersion24276);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFiles24277;
		 bool java.sql.DatabaseMetaData.usesLocalFiles() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFiles24277);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFiles24277);
		}
		internal static global::MonoJavaBridge.MethodId _usesLocalFilePerTable24278;
		 bool java.sql.DatabaseMetaData.usesLocalFilePerTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24278);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24278);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseIdentifiers24279;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24279);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseIdentifiers24280;
		 bool java.sql.DatabaseMetaData.storesUpperCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24280);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24280);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseIdentifiers24281;
		 bool java.sql.DatabaseMetaData.storesLowerCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24281);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24281);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseIdentifiers24282;
		 bool java.sql.DatabaseMetaData.storesMixedCaseIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24282);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24282);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMixedCaseQuotedIdentifiers24283;
		 bool java.sql.DatabaseMetaData.supportsMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24283);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24283);
		}
		internal static global::MonoJavaBridge.MethodId _storesUpperCaseQuotedIdentifiers24284;
		 bool java.sql.DatabaseMetaData.storesUpperCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24284);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24284);
		}
		internal static global::MonoJavaBridge.MethodId _storesLowerCaseQuotedIdentifiers24285;
		 bool java.sql.DatabaseMetaData.storesLowerCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24285);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24285);
		}
		internal static global::MonoJavaBridge.MethodId _storesMixedCaseQuotedIdentifiers24286;
		 bool java.sql.DatabaseMetaData.storesMixedCaseQuotedIdentifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24286);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24286);
		}
		internal static global::MonoJavaBridge.MethodId _getIdentifierQuoteString24287;
		 global::java.lang.String java.sql.DatabaseMetaData.getIdentifierQuoteString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24287)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24287)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSQLKeywords24288;
		 global::java.lang.String java.sql.DatabaseMetaData.getSQLKeywords() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLKeywords24288)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLKeywords24288)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNumericFunctions24289;
		 global::java.lang.String java.sql.DatabaseMetaData.getNumericFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getNumericFunctions24289)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getNumericFunctions24289)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getStringFunctions24290;
		 global::java.lang.String java.sql.DatabaseMetaData.getStringFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getStringFunctions24290)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getStringFunctions24290)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSystemFunctions24291;
		 global::java.lang.String java.sql.DatabaseMetaData.getSystemFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSystemFunctions24291)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSystemFunctions24291)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getTimeDateFunctions24292;
		 global::java.lang.String java.sql.DatabaseMetaData.getTimeDateFunctions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTimeDateFunctions24292)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTimeDateFunctions24292)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSearchStringEscape24293;
		 global::java.lang.String java.sql.DatabaseMetaData.getSearchStringEscape() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSearchStringEscape24293)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSearchStringEscape24293)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getExtraNameCharacters24294;
		 global::java.lang.String java.sql.DatabaseMetaData.getExtraNameCharacters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExtraNameCharacters24294)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExtraNameCharacters24294)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithAddColumn24295;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithAddColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24295);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24295);
		}
		internal static global::MonoJavaBridge.MethodId _supportsAlterTableWithDropColumn24296;
		 bool java.sql.DatabaseMetaData.supportsAlterTableWithDropColumn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24296);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24296);
		}
		internal static global::MonoJavaBridge.MethodId _supportsColumnAliasing24297;
		 bool java.sql.DatabaseMetaData.supportsColumnAliasing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsColumnAliasing24297);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsColumnAliasing24297);
		}
		internal static global::MonoJavaBridge.MethodId _nullPlusNonNullIsNull24298;
		 bool java.sql.DatabaseMetaData.nullPlusNonNullIsNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24298);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24298);
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24299;
		 bool java.sql.DatabaseMetaData.supportsConvert(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert24299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert24299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _supportsConvert24300;
		 bool java.sql.DatabaseMetaData.supportsConvert() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsConvert24300);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsConvert24300);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTableCorrelationNames24301;
		 bool java.sql.DatabaseMetaData.supportsTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24301);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24301);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDifferentTableCorrelationNames24302;
		 bool java.sql.DatabaseMetaData.supportsDifferentTableCorrelationNames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24302);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24302);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExpressionsInOrderBy24303;
		 bool java.sql.DatabaseMetaData.supportsExpressionsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24303);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24303);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOrderByUnrelated24304;
		 bool java.sql.DatabaseMetaData.supportsOrderByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24304);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24304);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupBy24305;
		 bool java.sql.DatabaseMetaData.supportsGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupBy24305);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupBy24305);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByUnrelated24306;
		 bool java.sql.DatabaseMetaData.supportsGroupByUnrelated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24306);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24306);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGroupByBeyondSelect24307;
		 bool java.sql.DatabaseMetaData.supportsGroupByBeyondSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24307);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24307);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLikeEscapeClause24308;
		 bool java.sql.DatabaseMetaData.supportsLikeEscapeClause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24308);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24308);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleResultSets24309;
		 bool java.sql.DatabaseMetaData.supportsMultipleResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24309);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24309);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleTransactions24310;
		 bool java.sql.DatabaseMetaData.supportsMultipleTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24310);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24310);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNonNullableColumns24311;
		 bool java.sql.DatabaseMetaData.supportsNonNullableColumns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24311);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24311);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMinimumSQLGrammar24312;
		 bool java.sql.DatabaseMetaData.supportsMinimumSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24312);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24312);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCoreSQLGrammar24313;
		 bool java.sql.DatabaseMetaData.supportsCoreSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24313);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24313);
		}
		internal static global::MonoJavaBridge.MethodId _supportsExtendedSQLGrammar24314;
		 bool java.sql.DatabaseMetaData.supportsExtendedSQLGrammar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24314);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24314);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92EntryLevelSQL24315;
		 bool java.sql.DatabaseMetaData.supportsANSI92EntryLevelSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24315);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24315);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92IntermediateSQL24316;
		 bool java.sql.DatabaseMetaData.supportsANSI92IntermediateSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24316);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24316);
		}
		internal static global::MonoJavaBridge.MethodId _supportsANSI92FullSQL24317;
		 bool java.sql.DatabaseMetaData.supportsANSI92FullSQL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24317);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24317);
		}
		internal static global::MonoJavaBridge.MethodId _supportsIntegrityEnhancementFacility24318;
		 bool java.sql.DatabaseMetaData.supportsIntegrityEnhancementFacility() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24318);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24318);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOuterJoins24319;
		 bool java.sql.DatabaseMetaData.supportsOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOuterJoins24319);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOuterJoins24319);
		}
		internal static global::MonoJavaBridge.MethodId _supportsFullOuterJoins24320;
		 bool java.sql.DatabaseMetaData.supportsFullOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24320);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24320);
		}
		internal static global::MonoJavaBridge.MethodId _supportsLimitedOuterJoins24321;
		 bool java.sql.DatabaseMetaData.supportsLimitedOuterJoins() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24321);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24321);
		}
		internal static global::MonoJavaBridge.MethodId _getSchemaTerm24322;
		 global::java.lang.String java.sql.DatabaseMetaData.getSchemaTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemaTerm24322)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemaTerm24322)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureTerm24323;
		 global::java.lang.String java.sql.DatabaseMetaData.getProcedureTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureTerm24323)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureTerm24323)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogTerm24324;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogTerm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogTerm24324)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogTerm24324)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isCatalogAtStart24325;
		 bool java.sql.DatabaseMetaData.isCatalogAtStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._isCatalogAtStart24325);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._isCatalogAtStart24325);
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogSeparator24326;
		 global::java.lang.String java.sql.DatabaseMetaData.getCatalogSeparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogSeparator24326)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogSeparator24326)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInDataManipulation24327;
		 bool java.sql.DatabaseMetaData.supportsSchemasInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24327);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24327);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInProcedureCalls24328;
		 bool java.sql.DatabaseMetaData.supportsSchemasInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24328);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24328);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInTableDefinitions24329;
		 bool java.sql.DatabaseMetaData.supportsSchemasInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24329);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24329);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInIndexDefinitions24330;
		 bool java.sql.DatabaseMetaData.supportsSchemasInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24330);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24330);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSchemasInPrivilegeDefinitions24331;
		 bool java.sql.DatabaseMetaData.supportsSchemasInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24331);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24331);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInDataManipulation24332;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInDataManipulation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24332);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24332);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInProcedureCalls24333;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInProcedureCalls() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24333);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24333);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInTableDefinitions24334;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInTableDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24334);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24334);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInIndexDefinitions24335;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInIndexDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24335);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24335);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCatalogsInPrivilegeDefinitions24336;
		 bool java.sql.DatabaseMetaData.supportsCatalogsInPrivilegeDefinitions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24336);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24336);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedDelete24337;
		 bool java.sql.DatabaseMetaData.supportsPositionedDelete() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedDelete24337);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedDelete24337);
		}
		internal static global::MonoJavaBridge.MethodId _supportsPositionedUpdate24338;
		 bool java.sql.DatabaseMetaData.supportsPositionedUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24338);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24338);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSelectForUpdate24339;
		 bool java.sql.DatabaseMetaData.supportsSelectForUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24339);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24339);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredProcedures24340;
		 bool java.sql.DatabaseMetaData.supportsStoredProcedures() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredProcedures24340);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredProcedures24340);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInComparisons24341;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInComparisons() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24341);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24341);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInExists24342;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInExists() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24342);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24342);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInIns24343;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInIns() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24343);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24343);
		}
		internal static global::MonoJavaBridge.MethodId _supportsSubqueriesInQuantifieds24344;
		 bool java.sql.DatabaseMetaData.supportsSubqueriesInQuantifieds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24344);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24344);
		}
		internal static global::MonoJavaBridge.MethodId _supportsCorrelatedSubqueries24345;
		 bool java.sql.DatabaseMetaData.supportsCorrelatedSubqueries() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24345);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24345);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnion24346;
		 bool java.sql.DatabaseMetaData.supportsUnion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnion24346);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnion24346);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUnionAll24347;
		 bool java.sql.DatabaseMetaData.supportsUnionAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsUnionAll24347);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsUnionAll24347);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossCommit24348;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24348);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24348);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenCursorsAcrossRollback24349;
		 bool java.sql.DatabaseMetaData.supportsOpenCursorsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24349);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24349);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossCommit24350;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24350);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24350);
		}
		internal static global::MonoJavaBridge.MethodId _supportsOpenStatementsAcrossRollback24351;
		 bool java.sql.DatabaseMetaData.supportsOpenStatementsAcrossRollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24351);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24351);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxBinaryLiteralLength24352;
		 int java.sql.DatabaseMetaData.getMaxBinaryLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24352);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24352);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCharLiteralLength24353;
		 int java.sql.DatabaseMetaData.getMaxCharLiteralLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24353);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24353);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnNameLength24354;
		 int java.sql.DatabaseMetaData.getMaxColumnNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24354);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24354);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInGroupBy24355;
		 int java.sql.DatabaseMetaData.getMaxColumnsInGroupBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24355);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24355);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInIndex24356;
		 int java.sql.DatabaseMetaData.getMaxColumnsInIndex() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24356);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24356);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInOrderBy24357;
		 int java.sql.DatabaseMetaData.getMaxColumnsInOrderBy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24357);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24357);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInSelect24358;
		 int java.sql.DatabaseMetaData.getMaxColumnsInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24358);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24358);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxColumnsInTable24359;
		 int java.sql.DatabaseMetaData.getMaxColumnsInTable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24359);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24359);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxConnections24360;
		 int java.sql.DatabaseMetaData.getMaxConnections() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxConnections24360);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxConnections24360);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCursorNameLength24361;
		 int java.sql.DatabaseMetaData.getMaxCursorNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24361);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24361);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxIndexLength24362;
		 int java.sql.DatabaseMetaData.getMaxIndexLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxIndexLength24362);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxIndexLength24362);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSchemaNameLength24363;
		 int java.sql.DatabaseMetaData.getMaxSchemaNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24363);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24363);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxProcedureNameLength24364;
		 int java.sql.DatabaseMetaData.getMaxProcedureNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24364);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24364);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxCatalogNameLength24365;
		 int java.sql.DatabaseMetaData.getMaxCatalogNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24365);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24365);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRowSize24366;
		 int java.sql.DatabaseMetaData.getMaxRowSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxRowSize24366);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxRowSize24366);
		}
		internal static global::MonoJavaBridge.MethodId _doesMaxRowSizeIncludeBlobs24367;
		 bool java.sql.DatabaseMetaData.doesMaxRowSizeIncludeBlobs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24367);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24367);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatementLength24368;
		 int java.sql.DatabaseMetaData.getMaxStatementLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatementLength24368);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatementLength24368);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxStatements24369;
		 int java.sql.DatabaseMetaData.getMaxStatements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxStatements24369);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxStatements24369);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTableNameLength24370;
		 int java.sql.DatabaseMetaData.getMaxTableNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTableNameLength24370);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTableNameLength24370);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTablesInSelect24371;
		 int java.sql.DatabaseMetaData.getMaxTablesInSelect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24371);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24371);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxUserNameLength24372;
		 int java.sql.DatabaseMetaData.getMaxUserNameLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getMaxUserNameLength24372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getMaxUserNameLength24372);
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultTransactionIsolation24373;
		 int java.sql.DatabaseMetaData.getDefaultTransactionIsolation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24373);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24373);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactions24374;
		 bool java.sql.DatabaseMetaData.supportsTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactions24374);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactions24374);
		}
		internal static global::MonoJavaBridge.MethodId _supportsTransactionIsolationLevel24375;
		 bool java.sql.DatabaseMetaData.supportsTransactionIsolationLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataDefinitionAndDataManipulationTransactions24376;
		 bool java.sql.DatabaseMetaData.supportsDataDefinitionAndDataManipulationTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24376);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24376);
		}
		internal static global::MonoJavaBridge.MethodId _supportsDataManipulationTransactionsOnly24377;
		 bool java.sql.DatabaseMetaData.supportsDataManipulationTransactionsOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24377);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24377);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionCausesTransactionCommit24378;
		 bool java.sql.DatabaseMetaData.dataDefinitionCausesTransactionCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24378);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24378);
		}
		internal static global::MonoJavaBridge.MethodId _dataDefinitionIgnoredInTransactions24379;
		 bool java.sql.DatabaseMetaData.dataDefinitionIgnoredInTransactions() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24379);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24379);
		}
		internal static global::MonoJavaBridge.MethodId _getProcedures24380;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedures(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedures24380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedures24380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getProcedureColumns24381;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getProcedureColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getProcedureColumns24381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getProcedureColumns24381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24382;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas24382)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas24382)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemas24383;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSchemas(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSchemas24383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSchemas24383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCatalogs24384;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCatalogs() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCatalogs24384)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCatalogs24384)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTableTypes24385;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTableTypes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTableTypes24385)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTableTypes24385)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumns24386;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumns24386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumns24386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getColumnPrivileges24387;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getColumnPrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getColumnPrivileges24387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getColumnPrivileges24387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTablePrivileges24388;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTablePrivileges(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTablePrivileges24388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTablePrivileges24388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getBestRowIdentifier24389;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getBestRowIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getBestRowIdentifier24389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getBestRowIdentifier24389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionColumns24390;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getVersionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getVersionColumns24390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getVersionColumns24390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getPrimaryKeys24391;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getPrimaryKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getPrimaryKeys24391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getPrimaryKeys24391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getImportedKeys24392;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getImportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getImportedKeys24392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getImportedKeys24392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getExportedKeys24393;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getExportedKeys(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getExportedKeys24393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getExportedKeys24393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getCrossReference24394;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getCrossReference(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.lang.String arg4, java.lang.String arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getCrossReference24394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getCrossReference24394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getTypeInfo24395;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getTypeInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getTypeInfo24395)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getTypeInfo24395)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getIndexInfo24396;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getIndexInfo(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, bool arg3, bool arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getIndexInfo24396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getIndexInfo24396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetType24397;
		 bool java.sql.DatabaseMetaData.supportsResultSetType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetType24397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetType24397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetConcurrency24398;
		 bool java.sql.DatabaseMetaData.supportsResultSetConcurrency(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ownUpdatesAreVisible24399;
		 bool java.sql.DatabaseMetaData.ownUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownDeletesAreVisible24400;
		 bool java.sql.DatabaseMetaData.ownDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ownInsertsAreVisible24401;
		 bool java.sql.DatabaseMetaData.ownInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersUpdatesAreVisible24402;
		 bool java.sql.DatabaseMetaData.othersUpdatesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersDeletesAreVisible24403;
		 bool java.sql.DatabaseMetaData.othersDeletesAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _othersInsertsAreVisible24404;
		 bool java.sql.DatabaseMetaData.othersInsertsAreVisible(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updatesAreDetected24405;
		 bool java.sql.DatabaseMetaData.updatesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._updatesAreDetected24405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._updatesAreDetected24405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deletesAreDetected24406;
		 bool java.sql.DatabaseMetaData.deletesAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._deletesAreDetected24406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._deletesAreDetected24406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _insertsAreDetected24407;
		 bool java.sql.DatabaseMetaData.insertsAreDetected(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._insertsAreDetected24407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._insertsAreDetected24407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _supportsBatchUpdates24408;
		 bool java.sql.DatabaseMetaData.supportsBatchUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsBatchUpdates24408);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsBatchUpdates24408);
		}
		internal static global::MonoJavaBridge.MethodId _getUDTs24409;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getUDTs(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getUDTs24409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getUDTs24409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsSavepoints24410;
		 bool java.sql.DatabaseMetaData.supportsSavepoints() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsSavepoints24410);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsSavepoints24410);
		}
		internal static global::MonoJavaBridge.MethodId _supportsNamedParameters24411;
		 bool java.sql.DatabaseMetaData.supportsNamedParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsNamedParameters24411);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsNamedParameters24411);
		}
		internal static global::MonoJavaBridge.MethodId _supportsMultipleOpenResults24412;
		 bool java.sql.DatabaseMetaData.supportsMultipleOpenResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24412);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24412);
		}
		internal static global::MonoJavaBridge.MethodId _supportsGetGeneratedKeys24413;
		 bool java.sql.DatabaseMetaData.supportsGetGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24413);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24413);
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTypes24414;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTypes(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTypes24414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTypes24414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getSuperTables24415;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getSuperTables(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSuperTables24415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSuperTables24415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _supportsResultSetHoldability24416;
		 bool java.sql.DatabaseMetaData.supportsResultSetHoldability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMajorVersion24417;
		 int java.sql.DatabaseMetaData.getDatabaseMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24417);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24417);
		}
		internal static global::MonoJavaBridge.MethodId _getDatabaseMinorVersion24418;
		 int java.sql.DatabaseMetaData.getDatabaseMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24418);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24418);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMajorVersion24419;
		 int java.sql.DatabaseMetaData.getJDBCMajorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24419);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24419);
		}
		internal static global::MonoJavaBridge.MethodId _getJDBCMinorVersion24420;
		 int java.sql.DatabaseMetaData.getJDBCMinorVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24420);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24420);
		}
		internal static global::MonoJavaBridge.MethodId _getSQLStateType24421;
		 int java.sql.DatabaseMetaData.getSQLStateType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getSQLStateType24421);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getSQLStateType24421);
		}
		internal static global::MonoJavaBridge.MethodId _locatorsUpdateCopy24422;
		 bool java.sql.DatabaseMetaData.locatorsUpdateCopy() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24422);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24422);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStatementPooling24423;
		 bool java.sql.DatabaseMetaData.supportsStatementPooling() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStatementPooling24423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStatementPooling24423);
		}
		internal static global::MonoJavaBridge.MethodId _supportsStoredFunctionsUsingCallSyntax24424;
		 bool java.sql.DatabaseMetaData.supportsStoredFunctionsUsingCallSyntax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24424);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24424);
		}
		internal static global::MonoJavaBridge.MethodId _autoCommitFailureClosesAllResultSets24425;
		 bool java.sql.DatabaseMetaData.autoCommitFailureClosesAllResultSets() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24425);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24425);
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfoProperties24426;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getClientInfoProperties() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getClientInfoProperties24426)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getClientInfoProperties24426)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctions24427;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctions(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctions24427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctions24427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getFunctionColumns24428;
		 global::java.sql.ResultSet java.sql.DatabaseMetaData.getFunctionColumns(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_._getFunctionColumns24428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.DatabaseMetaData_.staticClass, global::java.sql.DatabaseMetaData_._getFunctionColumns24428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.ResultSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DatabaseMetaData_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DatabaseMetaData"));
			global::java.sql.DatabaseMetaData_._getURL24258 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getURL", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isReadOnly24259 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isReadOnly", "()Z");
			global::java.sql.DatabaseMetaData_._getAttributes24260 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTables24261 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getConnection24262 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.DatabaseMetaData_._getUserName24263 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUserName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getResultSetHoldability24264 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.DatabaseMetaData_._allProceduresAreCallable24265 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allProceduresAreCallable", "()Z");
			global::java.sql.DatabaseMetaData_._allTablesAreSelectable24266 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "allTablesAreSelectable", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedHigh24267 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedHigh", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedLow24268 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedLow", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtStart24269 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._nullsAreSortedAtEnd24270 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullsAreSortedAtEnd", "()Z");
			global::java.sql.DatabaseMetaData_._getDatabaseProductName24271 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDatabaseProductVersion24272 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseProductVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverName24273 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverName", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverVersion24274 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverVersion", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getDriverMajorVersion24275 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDriverMinorVersion24276 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDriverMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._usesLocalFiles24277 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFiles", "()Z");
			global::java.sql.DatabaseMetaData_._usesLocalFilePerTable24278 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "usesLocalFilePerTable", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseIdentifiers24279 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseIdentifiers24280 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseIdentifiers24281 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseIdentifiers24282 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMixedCaseQuotedIdentifiers24283 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesUpperCaseQuotedIdentifiers24284 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesUpperCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesLowerCaseQuotedIdentifiers24285 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesLowerCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._storesMixedCaseQuotedIdentifiers24286 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "storesMixedCaseQuotedIdentifiers", "()Z");
			global::java.sql.DatabaseMetaData_._getIdentifierQuoteString24287 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIdentifierQuoteString", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSQLKeywords24288 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLKeywords", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getNumericFunctions24289 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getNumericFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getStringFunctions24290 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getStringFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSystemFunctions24291 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSystemFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getTimeDateFunctions24292 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTimeDateFunctions", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getSearchStringEscape24293 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSearchStringEscape", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getExtraNameCharacters24294 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExtraNameCharacters", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithAddColumn24295 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithAddColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsAlterTableWithDropColumn24296 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsAlterTableWithDropColumn", "()Z");
			global::java.sql.DatabaseMetaData_._supportsColumnAliasing24297 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsColumnAliasing", "()Z");
			global::java.sql.DatabaseMetaData_._nullPlusNonNullIsNull24298 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "nullPlusNonNullIsNull", "()Z");
			global::java.sql.DatabaseMetaData_._supportsConvert24299 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "(II)Z");
			global::java.sql.DatabaseMetaData_._supportsConvert24300 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsConvert", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTableCorrelationNames24301 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDifferentTableCorrelationNames24302 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDifferentTableCorrelationNames", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExpressionsInOrderBy24303 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExpressionsInOrderBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOrderByUnrelated24304 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOrderByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupBy24305 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupBy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByUnrelated24306 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByUnrelated", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGroupByBeyondSelect24307 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGroupByBeyondSelect", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLikeEscapeClause24308 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLikeEscapeClause", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleResultSets24309 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleTransactions24310 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNonNullableColumns24311 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNonNullableColumns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMinimumSQLGrammar24312 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMinimumSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCoreSQLGrammar24313 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCoreSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsExtendedSQLGrammar24314 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsExtendedSQLGrammar", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92EntryLevelSQL24315 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92EntryLevelSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92IntermediateSQL24316 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92IntermediateSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsANSI92FullSQL24317 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsANSI92FullSQL", "()Z");
			global::java.sql.DatabaseMetaData_._supportsIntegrityEnhancementFacility24318 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsIntegrityEnhancementFacility", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOuterJoins24319 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsFullOuterJoins24320 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsFullOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._supportsLimitedOuterJoins24321 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsLimitedOuterJoins", "()Z");
			global::java.sql.DatabaseMetaData_._getSchemaTerm24322 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemaTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getProcedureTerm24323 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._getCatalogTerm24324 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogTerm", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._isCatalogAtStart24325 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "isCatalogAtStart", "()Z");
			global::java.sql.DatabaseMetaData_._getCatalogSeparator24326 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogSeparator", "()Ljava/lang/String;");
			global::java.sql.DatabaseMetaData_._supportsSchemasInDataManipulation24327 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInProcedureCalls24328 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInTableDefinitions24329 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInIndexDefinitions24330 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSchemasInPrivilegeDefinitions24331 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSchemasInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInDataManipulation24332 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInDataManipulation", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInProcedureCalls24333 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInProcedureCalls", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInTableDefinitions24334 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInTableDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInIndexDefinitions24335 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInIndexDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCatalogsInPrivilegeDefinitions24336 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCatalogsInPrivilegeDefinitions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedDelete24337 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedDelete", "()Z");
			global::java.sql.DatabaseMetaData_._supportsPositionedUpdate24338 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsPositionedUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSelectForUpdate24339 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSelectForUpdate", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredProcedures24340 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredProcedures", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInComparisons24341 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInComparisons", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInExists24342 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInExists", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInIns24343 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInIns", "()Z");
			global::java.sql.DatabaseMetaData_._supportsSubqueriesInQuantifieds24344 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSubqueriesInQuantifieds", "()Z");
			global::java.sql.DatabaseMetaData_._supportsCorrelatedSubqueries24345 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsCorrelatedSubqueries", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnion24346 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnion", "()Z");
			global::java.sql.DatabaseMetaData_._supportsUnionAll24347 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsUnionAll", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossCommit24348 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenCursorsAcrossRollback24349 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenCursorsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossCommit24350 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossCommit", "()Z");
			global::java.sql.DatabaseMetaData_._supportsOpenStatementsAcrossRollback24351 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsOpenStatementsAcrossRollback", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxBinaryLiteralLength24352 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxBinaryLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCharLiteralLength24353 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCharLiteralLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnNameLength24354 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInGroupBy24355 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInGroupBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInIndex24356 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInIndex", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInOrderBy24357 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInOrderBy", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInSelect24358 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxColumnsInTable24359 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxColumnsInTable", "()I");
			global::java.sql.DatabaseMetaData_._getMaxConnections24360 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxConnections", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCursorNameLength24361 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCursorNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxIndexLength24362 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxIndexLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxSchemaNameLength24363 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxSchemaNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxProcedureNameLength24364 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxProcedureNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxCatalogNameLength24365 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxCatalogNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxRowSize24366 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxRowSize", "()I");
			global::java.sql.DatabaseMetaData_._doesMaxRowSizeIncludeBlobs24367 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "doesMaxRowSizeIncludeBlobs", "()Z");
			global::java.sql.DatabaseMetaData_._getMaxStatementLength24368 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatementLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxStatements24369 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxStatements", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTableNameLength24370 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTableNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getMaxTablesInSelect24371 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxTablesInSelect", "()I");
			global::java.sql.DatabaseMetaData_._getMaxUserNameLength24372 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getMaxUserNameLength", "()I");
			global::java.sql.DatabaseMetaData_._getDefaultTransactionIsolation24373 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDefaultTransactionIsolation", "()I");
			global::java.sql.DatabaseMetaData_._supportsTransactions24374 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsTransactionIsolationLevel24375 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsTransactionIsolationLevel", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsDataDefinitionAndDataManipulationTransactions24376 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataDefinitionAndDataManipulationTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._supportsDataManipulationTransactionsOnly24377 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsDataManipulationTransactionsOnly", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionCausesTransactionCommit24378 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionCausesTransactionCommit", "()Z");
			global::java.sql.DatabaseMetaData_._dataDefinitionIgnoredInTransactions24379 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "dataDefinitionIgnoredInTransactions", "()Z");
			global::java.sql.DatabaseMetaData_._getProcedures24380 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getProcedureColumns24381 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas24382 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSchemas24383 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCatalogs24384 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCatalogs", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTableTypes24385 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTableTypes", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumns24386 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getColumnPrivileges24387 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTablePrivileges24388 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getBestRowIdentifier24389 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getVersionColumns24390 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getPrimaryKeys24391 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getImportedKeys24392 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getExportedKeys24393 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getCrossReference24394 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getTypeInfo24395 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getTypeInfo", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getIndexInfo24396 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetType24397 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetType", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsResultSetConcurrency24398 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetConcurrency", "(II)Z");
			global::java.sql.DatabaseMetaData_._ownUpdatesAreVisible24399 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownDeletesAreVisible24400 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._ownInsertsAreVisible24401 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "ownInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersUpdatesAreVisible24402 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersUpdatesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersDeletesAreVisible24403 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersDeletesAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._othersInsertsAreVisible24404 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "othersInsertsAreVisible", "(I)Z");
			global::java.sql.DatabaseMetaData_._updatesAreDetected24405 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "updatesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._deletesAreDetected24406 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "deletesAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._insertsAreDetected24407 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "insertsAreDetected", "(I)Z");
			global::java.sql.DatabaseMetaData_._supportsBatchUpdates24408 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsBatchUpdates", "()Z");
			global::java.sql.DatabaseMetaData_._getUDTs24409 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsSavepoints24410 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsSavepoints", "()Z");
			global::java.sql.DatabaseMetaData_._supportsNamedParameters24411 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsNamedParameters", "()Z");
			global::java.sql.DatabaseMetaData_._supportsMultipleOpenResults24412 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsMultipleOpenResults", "()Z");
			global::java.sql.DatabaseMetaData_._supportsGetGeneratedKeys24413 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsGetGeneratedKeys", "()Z");
			global::java.sql.DatabaseMetaData_._getSuperTypes24414 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getSuperTables24415 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._supportsResultSetHoldability24416 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsResultSetHoldability", "(I)Z");
			global::java.sql.DatabaseMetaData_._getDatabaseMajorVersion24417 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getDatabaseMinorVersion24418 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getDatabaseMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMajorVersion24419 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMajorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getJDBCMinorVersion24420 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getJDBCMinorVersion", "()I");
			global::java.sql.DatabaseMetaData_._getSQLStateType24421 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getSQLStateType", "()I");
			global::java.sql.DatabaseMetaData_._locatorsUpdateCopy24422 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "locatorsUpdateCopy", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStatementPooling24423 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStatementPooling", "()Z");
			global::java.sql.DatabaseMetaData_._supportsStoredFunctionsUsingCallSyntax24424 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "supportsStoredFunctionsUsingCallSyntax", "()Z");
			global::java.sql.DatabaseMetaData_._autoCommitFailureClosesAllResultSets24425 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "autoCommitFailureClosesAllResultSets", "()Z");
			global::java.sql.DatabaseMetaData_._getClientInfoProperties24426 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getClientInfoProperties", "()Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctions24427 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.DatabaseMetaData_._getFunctionColumns24428 = @__env.GetMethodIDNoThrow(global::java.sql.DatabaseMetaData_.staticClass, "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;");
		}
	}
}
