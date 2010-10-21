namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Statement_))]
	public interface Statement  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Statement_ : java.lang.Object, Statement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Statement_()
		{
			InitJNI();
		}
		internal Statement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close24926;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._close24926);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._close24926);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24927;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isClosed24927);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isClosed24927);
		}
		internal static global::MonoJavaBridge.MethodId _execute24928;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute24928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute24928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24929;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute24929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute24929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24930;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute24930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute24930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute24931;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute24931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute24931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel24932;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._cancel24932);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._cancel24932);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24933;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._addBatch24933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._addBatch24933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24934;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getConnection24934)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getConnection24934)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24935;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getResultSet24935)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSet24935)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24936;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getWarnings24936)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getWarnings24936)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24937;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearWarnings24937);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearWarnings24937);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24938;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchDirection24938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchDirection24938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24939;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchDirection24939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchDirection24939);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24940;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchSize24940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchSize24940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24941;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchSize24941);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchSize24941);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24942;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeQuery24942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeQuery24942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24943;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate24943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate24943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24944;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate24944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate24944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24945;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate24945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate24945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24946;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate24946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate24946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize24947;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxFieldSize24947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxFieldSize24947);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize24948;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxFieldSize24948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxFieldSize24948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows24949;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxRows24949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxRows24949);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows24950;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxRows24950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxRows24950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing24951;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setEscapeProcessing24951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setEscapeProcessing24951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout24952;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getQueryTimeout24952);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getQueryTimeout24952);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout24953;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setQueryTimeout24953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setQueryTimeout24953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName24954;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setCursorName24954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setCursorName24954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount24955;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getUpdateCount24955);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getUpdateCount24955);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24956;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults24956);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults24956);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24957;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults24957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults24957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency24958;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetConcurrency24958);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetConcurrency24958);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType24959;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetType24959);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetType24959);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch24960;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearBatch24960);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearBatch24960);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch24961;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeBatch24961)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeBatch24961)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys24962;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getGeneratedKeys24962)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getGeneratedKeys24962)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24963;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetHoldability24963);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetHoldability24963);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable24964;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setPoolable24964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setPoolable24964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable24965;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isPoolable24965);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isPoolable24965);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Statement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Statement"));
			global::java.sql.Statement_._close24926 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "close", "()V");
			global::java.sql.Statement_._isClosed24927 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isClosed", "()Z");
			global::java.sql.Statement_._execute24928 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.Statement_._execute24929 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.Statement_._execute24930 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.Statement_._execute24931 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.Statement_._cancel24932 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "cancel", "()V");
			global::java.sql.Statement_._addBatch24933 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getConnection24934 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.Statement_._getResultSet24935 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getWarnings24936 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.Statement_._clearWarnings24937 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearWarnings", "()V");
			global::java.sql.Statement_._setFetchDirection24938 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.Statement_._getFetchDirection24939 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.Statement_._setFetchSize24940 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.Statement_._getFetchSize24941 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchSize", "()I");
			global::java.sql.Statement_._executeQuery24942 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.Statement_._executeUpdate24943 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.Statement_._executeUpdate24944 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.Statement_._executeUpdate24945 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.Statement_._executeUpdate24946 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.Statement_._getMaxFieldSize24947 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.Statement_._setMaxFieldSize24948 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.Statement_._getMaxRows24949 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxRows", "()I");
			global::java.sql.Statement_._setMaxRows24950 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.Statement_._setEscapeProcessing24951 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.Statement_._getQueryTimeout24952 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.Statement_._setQueryTimeout24953 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.Statement_._setCursorName24954 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getUpdateCount24955 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.Statement_._getMoreResults24956 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.Statement_._getMoreResults24957 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.Statement_._getResultSetConcurrency24958 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.Statement_._getResultSetType24959 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetType", "()I");
			global::java.sql.Statement_._clearBatch24960 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearBatch", "()V");
			global::java.sql.Statement_._executeBatch24961 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeBatch", "()[I");
			global::java.sql.Statement_._getGeneratedKeys24962 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getResultSetHoldability24963 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.Statement_._setPoolable24964 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.Statement_._isPoolable24965 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isPoolable", "()Z");
		}
	}
}
