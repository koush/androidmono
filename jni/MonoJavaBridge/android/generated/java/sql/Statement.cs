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
		internal static global::MonoJavaBridge.MethodId _close19231;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._close19231);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._close19231);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed19232;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isClosed19232);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isClosed19232);
		}
		internal static global::MonoJavaBridge.MethodId _execute19233;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute19233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute19233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute19234;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute19234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute19234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute19235;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute19235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute19235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute19236;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._execute19236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._execute19236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel19237;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._cancel19237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._cancel19237);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch19238;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._addBatch19238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._addBatch19238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection19239;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getConnection19239)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getConnection19239)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet19240;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getResultSet19240)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSet19240)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings19241;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getWarnings19241)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getWarnings19241)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings19242;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearWarnings19242);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearWarnings19242);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection19243;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchDirection19243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchDirection19243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection19244;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchDirection19244);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchDirection19244);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize19245;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setFetchSize19245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setFetchSize19245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize19246;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getFetchSize19246);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getFetchSize19246);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery19247;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeQuery19247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeQuery19247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate19248;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate19248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate19248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate19249;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate19249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate19249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate19250;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate19250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate19250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate19251;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._executeUpdate19251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeUpdate19251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize19252;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxFieldSize19252);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxFieldSize19252);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize19253;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxFieldSize19253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxFieldSize19253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows19254;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getMaxRows19254);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMaxRows19254);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows19255;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setMaxRows19255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setMaxRows19255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing19256;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setEscapeProcessing19256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setEscapeProcessing19256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout19257;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getQueryTimeout19257);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getQueryTimeout19257);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout19258;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setQueryTimeout19258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setQueryTimeout19258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName19259;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setCursorName19259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setCursorName19259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount19260;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getUpdateCount19260);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getUpdateCount19260);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults19261;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults19261);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults19261);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults19262;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._getMoreResults19262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getMoreResults19262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency19263;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetConcurrency19263);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetConcurrency19263);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType19264;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetType19264);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetType19264);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch19265;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._clearBatch19265);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._clearBatch19265);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch19266;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._executeBatch19266)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._executeBatch19266)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys19267;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Statement_._getGeneratedKeys19267)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getGeneratedKeys19267)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability19268;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Statement_._getResultSetHoldability19268);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._getResultSetHoldability19268);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable19269;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Statement_._setPoolable19269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._setPoolable19269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable19270;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Statement_._isPoolable19270);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Statement_.staticClass, global::java.sql.Statement_._isPoolable19270);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Statement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Statement"));
			global::java.sql.Statement_._close19231 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "close", "()V");
			global::java.sql.Statement_._isClosed19232 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isClosed", "()Z");
			global::java.sql.Statement_._execute19233 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.Statement_._execute19234 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.Statement_._execute19235 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.Statement_._execute19236 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.Statement_._cancel19237 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "cancel", "()V");
			global::java.sql.Statement_._addBatch19238 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getConnection19239 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.Statement_._getResultSet19240 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getWarnings19241 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.Statement_._clearWarnings19242 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearWarnings", "()V");
			global::java.sql.Statement_._setFetchDirection19243 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.Statement_._getFetchDirection19244 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.Statement_._setFetchSize19245 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.Statement_._getFetchSize19246 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getFetchSize", "()I");
			global::java.sql.Statement_._executeQuery19247 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.Statement_._executeUpdate19248 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.Statement_._executeUpdate19249 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.Statement_._executeUpdate19250 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.Statement_._executeUpdate19251 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.Statement_._getMaxFieldSize19252 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.Statement_._setMaxFieldSize19253 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.Statement_._getMaxRows19254 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMaxRows", "()I");
			global::java.sql.Statement_._setMaxRows19255 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.Statement_._setEscapeProcessing19256 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.Statement_._getQueryTimeout19257 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.Statement_._setQueryTimeout19258 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.Statement_._setCursorName19259 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.Statement_._getUpdateCount19260 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.Statement_._getMoreResults19261 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.Statement_._getMoreResults19262 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.Statement_._getResultSetConcurrency19263 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.Statement_._getResultSetType19264 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetType", "()I");
			global::java.sql.Statement_._clearBatch19265 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "clearBatch", "()V");
			global::java.sql.Statement_._executeBatch19266 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "executeBatch", "()[I");
			global::java.sql.Statement_._getGeneratedKeys19267 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.Statement_._getResultSetHoldability19268 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.Statement_._setPoolable19269 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.Statement_._isPoolable19270 = @__env.GetMethodIDNoThrow(global::java.sql.Statement_.staticClass, "isPoolable", "()Z");
		}
	}
}
