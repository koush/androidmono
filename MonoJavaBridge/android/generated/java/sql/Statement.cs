namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Statement_))]
	public partial interface Statement  : global::MonoJavaBridge.IJavaObject 
	{
		void close();
		bool isClosed();
		bool execute(java.lang.String arg0, int[] arg1);
		bool execute(java.lang.String arg0, int arg1);
		bool execute(java.lang.String arg0);
		bool execute(java.lang.String arg0, java.lang.String[] arg1);
		void cancel();
		void addBatch(java.lang.String arg0);
		global::java.sql.Connection getConnection();
		global::java.sql.ResultSet getResultSet();
		global::java.sql.SQLWarning getWarnings();
		void clearWarnings();
		void setFetchDirection(int arg0);
		int getFetchDirection();
		void setFetchSize(int arg0);
		int getFetchSize();
		global::java.sql.ResultSet executeQuery(java.lang.String arg0);
		int executeUpdate(java.lang.String arg0, int arg1);
		int executeUpdate(java.lang.String arg0, int[] arg1);
		int executeUpdate(java.lang.String arg0);
		int executeUpdate(java.lang.String arg0, java.lang.String[] arg1);
		int getMaxFieldSize();
		void setMaxFieldSize(int arg0);
		int getMaxRows();
		void setMaxRows(int arg0);
		void setEscapeProcessing(bool arg0);
		int getQueryTimeout();
		void setQueryTimeout(int arg0);
		void setCursorName(java.lang.String arg0);
		int getUpdateCount();
		bool getMoreResults();
		bool getMoreResults(int arg0);
		int getResultSetConcurrency();
		int getResultSetType();
		void clearBatch();
		int[] executeBatch();
		global::java.sql.ResultSet getGeneratedKeys();
		int getResultSetHoldability();
		void setPoolable(bool arg0);
		bool isPoolable();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Statement))]
	internal sealed partial class Statement_ : java.lang.Object, Statement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Statement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close25045;
		void java.sql.Statement.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._close25045);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._close25045);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed25046;
		bool java.sql.Statement.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isClosed25046);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isClosed25046);
		}
		internal static global::MonoJavaBridge.MethodId _execute25047;
		bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute25047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute25047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute25048;
		bool java.sql.Statement.execute(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute25048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute25048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute25049;
		bool java.sql.Statement.execute(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute25049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute25049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute25050;
		bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute25050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute25050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel25051;
		void java.sql.Statement.cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._cancel25051);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._cancel25051);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch25052;
		void java.sql.Statement.addBatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._addBatch25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._addBatch25052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection25053;
		global::java.sql.Connection java.sql.Statement.getConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getConnection25053)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getConnection25053)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet25054;
		global::java.sql.ResultSet java.sql.Statement.getResultSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getResultSet25054)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSet25054)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings25055;
		global::java.sql.SQLWarning java.sql.Statement.getWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getWarnings25055)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getWarnings25055)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings25056;
		void java.sql.Statement.clearWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearWarnings25056);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearWarnings25056);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection25057;
		void java.sql.Statement.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchDirection25057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchDirection25057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection25058;
		int java.sql.Statement.getFetchDirection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchDirection25058);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchDirection25058);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize25059;
		void java.sql.Statement.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchSize25059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchSize25059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize25060;
		int java.sql.Statement.getFetchSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchSize25060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchSize25060);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery25061;
		global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeQuery25061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeQuery25061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate25062;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate25062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate25062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate25063;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate25063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate25063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate25064;
		int java.sql.Statement.executeUpdate(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate25064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate25064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate25065;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate25065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate25065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize25066;
		int java.sql.Statement.getMaxFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxFieldSize25066);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxFieldSize25066);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize25067;
		void java.sql.Statement.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxFieldSize25067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxFieldSize25067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows25068;
		int java.sql.Statement.getMaxRows()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxRows25068);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxRows25068);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows25069;
		void java.sql.Statement.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxRows25069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxRows25069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing25070;
		void java.sql.Statement.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setEscapeProcessing25070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setEscapeProcessing25070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout25071;
		int java.sql.Statement.getQueryTimeout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getQueryTimeout25071);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getQueryTimeout25071);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout25072;
		void java.sql.Statement.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setQueryTimeout25072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setQueryTimeout25072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName25073;
		void java.sql.Statement.setCursorName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setCursorName25073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setCursorName25073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount25074;
		int java.sql.Statement.getUpdateCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getUpdateCount25074);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getUpdateCount25074);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults25075;
		bool java.sql.Statement.getMoreResults()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults25075);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults25075);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults25076;
		bool java.sql.Statement.getMoreResults(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults25076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults25076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency25077;
		int java.sql.Statement.getResultSetConcurrency()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetConcurrency25077);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetConcurrency25077);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType25078;
		int java.sql.Statement.getResultSetType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetType25078);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetType25078);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch25079;
		void java.sql.Statement.clearBatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearBatch25079);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearBatch25079);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch25080;
		int[] java.sql.Statement.executeBatch()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeBatch25080)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeBatch25080)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys25081;
		global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getGeneratedKeys25081)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getGeneratedKeys25081)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability25082;
		int java.sql.Statement.getResultSetHoldability()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetHoldability25082);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetHoldability25082);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable25083;
		void java.sql.Statement.setPoolable(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setPoolable25083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setPoolable25083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable25084;
		bool java.sql.Statement.isPoolable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isPoolable25084);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isPoolable25084);
		}
		static Statement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Statement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Statement"));
			global::java.sql.Statement_._close25045 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "close", "()V");
			global::java.sql.Statement_._isClosed25046 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isClosed", "()Z");
			global::java.sql.Statement_._execute25047 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.Statement_._execute25048 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.Statement_._execute25049 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.Statement_._execute25050 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.Statement_._cancel25051 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "cancel", "()V");
			global::java.sql.Statement_._addBatch25052 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getConnection25053 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.Statement_._getResultSet25054 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getWarnings25055 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.Statement_._clearWarnings25056 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearWarnings", "()V");
			global::java.sql.Statement_._setFetchDirection25057 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.Statement_._getFetchDirection25058 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.Statement_._setFetchSize25059 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.Statement_._getFetchSize25060 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchSize", "()I");
			global::java.sql.Statement_._executeQuery25061 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.Statement_._executeUpdate25062 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.Statement_._executeUpdate25063 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.Statement_._executeUpdate25064 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.Statement_._executeUpdate25065 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.Statement_._getMaxFieldSize25066 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.Statement_._setMaxFieldSize25067 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.Statement_._getMaxRows25068 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxRows", "()I");
			global::java.sql.Statement_._setMaxRows25069 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.Statement_._setEscapeProcessing25070 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.Statement_._getQueryTimeout25071 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.Statement_._setQueryTimeout25072 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.Statement_._setCursorName25073 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getUpdateCount25074 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.Statement_._getMoreResults25075 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.Statement_._getMoreResults25076 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.Statement_._getResultSetConcurrency25077 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.Statement_._getResultSetType25078 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetType", "()I");
			global::java.sql.Statement_._clearBatch25079 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearBatch", "()V");
			global::java.sql.Statement_._executeBatch25080 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeBatch", "()[I");
			global::java.sql.Statement_._getGeneratedKeys25081 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getResultSetHoldability25082 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.Statement_._setPoolable25083 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.Statement_._isPoolable25084 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isPoolable", "()Z");
		}
		internal static void InitJNI()
		{
		}
	}
}