namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Connection_))]
	public interface Connection  : global::MonoJavaBridge.IJavaObject 
	{
		void setReadOnly(bool arg0);
		void close();
		bool isReadOnly();
		bool isClosed();
		bool isValid(int arg0);
		void commit();
		global::java.sql.SQLWarning getWarnings();
		void clearWarnings();
		global::java.sql.DatabaseMetaData getMetaData();
		int getHoldability();
		global::java.sql.Statement createStatement(int arg0, int arg1, int arg2);
		global::java.sql.Statement createStatement(int arg0, int arg1);
		global::java.sql.Statement createStatement();
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0, int arg1);
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0);
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0, java.lang.String[] arg1);
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0, int[] arg1);
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0, int arg1, int arg2);
		global::java.sql.PreparedStatement prepareStatement(java.lang.String arg0, int arg1, int arg2, int arg3);
		global::java.sql.CallableStatement prepareCall(java.lang.String arg0, int arg1, int arg2);
		global::java.sql.CallableStatement prepareCall(java.lang.String arg0, int arg1, int arg2, int arg3);
		global::java.sql.CallableStatement prepareCall(java.lang.String arg0);
		global::java.lang.String nativeSQL(java.lang.String arg0);
		void setAutoCommit(bool arg0);
		bool getAutoCommit();
		void rollback(java.sql.Savepoint arg0);
		void rollback();
		void setCatalog(java.lang.String arg0);
		global::java.lang.String getCatalog();
		void setTransactionIsolation(int arg0);
		int getTransactionIsolation();
		global::java.util.Map getTypeMap();
		void setTypeMap(java.util.Map arg0);
		void setHoldability(int arg0);
		global::java.sql.Savepoint setSavepoint();
		global::java.sql.Savepoint setSavepoint(java.lang.String arg0);
		void releaseSavepoint(java.sql.Savepoint arg0);
		global::java.sql.Clob createClob();
		global::java.sql.Blob createBlob();
		void setClientInfo(java.lang.String arg0, java.lang.String arg1);
		void setClientInfo(java.util.Properties arg0);
		global::java.lang.String getClientInfo(java.lang.String arg0);
		global::java.util.Properties getClientInfo();
		global::java.sql.Array createArrayOf(java.lang.String arg0, java.lang.Object[] arg1);
		global::java.sql.Struct createStruct(java.lang.String arg0, java.lang.Object[] arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Connection))]
	public sealed partial class Connection_ : java.lang.Object, Connection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Connection_()
		{
			InitJNI();
		}
		internal Connection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly18592;
		 void java.sql.Connection.setReadOnly(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setReadOnly18592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setReadOnly18592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close18593;
		 void java.sql.Connection.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._close18593);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._close18593);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly18594;
		 bool java.sql.Connection.isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isReadOnly18594);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isReadOnly18594);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed18595;
		 bool java.sql.Connection.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isClosed18595);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isClosed18595);
		}
		internal static global::MonoJavaBridge.MethodId _isValid18596;
		 bool java.sql.Connection.isValid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isValid18596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isValid18596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _commit18597;
		 void java.sql.Connection.commit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._commit18597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._commit18597);
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings18598;
		 global::java.sql.SQLWarning java.sql.Connection.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getWarnings18598)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getWarnings18598)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings18599;
		 void java.sql.Connection.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._clearWarnings18599);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._clearWarnings18599);
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData18600;
		 global::java.sql.DatabaseMetaData java.sql.Connection.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.DatabaseMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getMetaData18600)) as java.sql.DatabaseMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.DatabaseMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getMetaData18600)) as java.sql.DatabaseMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability18601;
		 int java.sql.Connection.getHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Connection_._getHoldability18601);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getHoldability18601);
		}
		internal static global::MonoJavaBridge.MethodId _createStatement18602;
		 global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement18602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement18602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _createStatement18603;
		 global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement18603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement18603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _createStatement18604;
		 global::java.sql.Statement java.sql.Connection.createStatement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement18604)) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement18604)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18605;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18606;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18607;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18608;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18609;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement18610;
		 global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement18610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement18610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall18611;
		 global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall18611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall18611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall18612;
		 global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall18612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall18612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall18613;
		 global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall18613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall18613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _nativeSQL18614;
		 global::java.lang.String java.sql.Connection.nativeSQL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._nativeSQL18614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._nativeSQL18614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoCommit18615;
		 void java.sql.Connection.setAutoCommit(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setAutoCommit18615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setAutoCommit18615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAutoCommit18616;
		 bool java.sql.Connection.getAutoCommit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._getAutoCommit18616);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getAutoCommit18616);
		}
		internal static global::MonoJavaBridge.MethodId _rollback18617;
		 void java.sql.Connection.rollback(java.sql.Savepoint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._rollback18617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._rollback18617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rollback18618;
		 void java.sql.Connection.rollback() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._rollback18618);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._rollback18618);
		}
		internal static global::MonoJavaBridge.MethodId _setCatalog18619;
		 void java.sql.Connection.setCatalog(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setCatalog18619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setCatalog18619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCatalog18620;
		 global::java.lang.String java.sql.Connection.getCatalog() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getCatalog18620)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getCatalog18620)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionIsolation18621;
		 void java.sql.Connection.setTransactionIsolation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setTransactionIsolation18621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setTransactionIsolation18621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransactionIsolation18622;
		 int java.sql.Connection.getTransactionIsolation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Connection_._getTransactionIsolation18622);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getTransactionIsolation18622);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeMap18623;
		 global::java.util.Map java.sql.Connection.getTypeMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getTypeMap18623)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getTypeMap18623)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeMap18624;
		 void java.sql.Connection.setTypeMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setTypeMap18624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setTypeMap18624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHoldability18625;
		 void java.sql.Connection.setHoldability(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setHoldability18625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setHoldability18625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSavepoint18626;
		 global::java.sql.Savepoint java.sql.Connection.setSavepoint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._setSavepoint18626)) as java.sql.Savepoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setSavepoint18626)) as java.sql.Savepoint;
		}
		internal static global::MonoJavaBridge.MethodId _setSavepoint18627;
		 global::java.sql.Savepoint java.sql.Connection.setSavepoint(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._setSavepoint18627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Savepoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setSavepoint18627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Savepoint;
		}
		internal static global::MonoJavaBridge.MethodId _releaseSavepoint18628;
		 void java.sql.Connection.releaseSavepoint(java.sql.Savepoint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._releaseSavepoint18628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._releaseSavepoint18628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createClob18629;
		 global::java.sql.Clob java.sql.Connection.createClob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createClob18629)) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createClob18629)) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _createBlob18630;
		 global::java.sql.Blob java.sql.Connection.createBlob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createBlob18630)) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createBlob18630)) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _setClientInfo18631;
		 void java.sql.Connection.setClientInfo(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setClientInfo18631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setClientInfo18631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClientInfo18632;
		 void java.sql.Connection.setClientInfo(java.util.Properties arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setClientInfo18632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setClientInfo18632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfo18633;
		 global::java.lang.String java.sql.Connection.getClientInfo(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getClientInfo18633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getClientInfo18633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfo18634;
		 global::java.util.Properties java.sql.Connection.getClientInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getClientInfo18634)) as java.util.Properties;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getClientInfo18634)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _createArrayOf18635;
		 global::java.sql.Array java.sql.Connection.createArrayOf(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createArrayOf18635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createArrayOf18635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _createStruct18636;
		 global::java.sql.Struct java.sql.Connection.createStruct(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Struct>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStruct18636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Struct;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Struct>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStruct18636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Struct;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Connection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Connection"));
			global::java.sql.Connection_._setReadOnly18592 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setReadOnly", "(Z)V");
			global::java.sql.Connection_._close18593 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "close", "()V");
			global::java.sql.Connection_._isReadOnly18594 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isReadOnly", "()Z");
			global::java.sql.Connection_._isClosed18595 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isClosed", "()Z");
			global::java.sql.Connection_._isValid18596 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isValid", "(I)Z");
			global::java.sql.Connection_._commit18597 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "commit", "()V");
			global::java.sql.Connection_._getWarnings18598 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.Connection_._clearWarnings18599 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "clearWarnings", "()V");
			global::java.sql.Connection_._getMetaData18600 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getMetaData", "()Ljava/sql/DatabaseMetaData;");
			global::java.sql.Connection_._getHoldability18601 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getHoldability", "()I");
			global::java.sql.Connection_._createStatement18602 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "(III)Ljava/sql/Statement;");
			global::java.sql.Connection_._createStatement18603 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "(II)Ljava/sql/Statement;");
			global::java.sql.Connection_._createStatement18604 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "()Ljava/sql/Statement;");
			global::java.sql.Connection_._prepareStatement18605 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;I)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement18606 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement18607 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement18608 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[I)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement18609 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;II)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement18610 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;III)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareCall18611 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;II)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._prepareCall18612 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;III)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._prepareCall18613 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._nativeSQL18614 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "nativeSQL", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.Connection_._setAutoCommit18615 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setAutoCommit", "(Z)V");
			global::java.sql.Connection_._getAutoCommit18616 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getAutoCommit", "()Z");
			global::java.sql.Connection_._rollback18617 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "rollback", "(Ljava/sql/Savepoint;)V");
			global::java.sql.Connection_._rollback18618 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "rollback", "()V");
			global::java.sql.Connection_._setCatalog18619 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setCatalog", "(Ljava/lang/String;)V");
			global::java.sql.Connection_._getCatalog18620 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getCatalog", "()Ljava/lang/String;");
			global::java.sql.Connection_._setTransactionIsolation18621 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setTransactionIsolation", "(I)V");
			global::java.sql.Connection_._getTransactionIsolation18622 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getTransactionIsolation", "()I");
			global::java.sql.Connection_._getTypeMap18623 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getTypeMap", "()Ljava/util/Map;");
			global::java.sql.Connection_._setTypeMap18624 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setTypeMap", "(Ljava/util/Map;)V");
			global::java.sql.Connection_._setHoldability18625 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setHoldability", "(I)V");
			global::java.sql.Connection_._setSavepoint18626 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setSavepoint", "()Ljava/sql/Savepoint;");
			global::java.sql.Connection_._setSavepoint18627 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setSavepoint", "(Ljava/lang/String;)Ljava/sql/Savepoint;");
			global::java.sql.Connection_._releaseSavepoint18628 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "releaseSavepoint", "(Ljava/sql/Savepoint;)V");
			global::java.sql.Connection_._createClob18629 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createClob", "()Ljava/sql/Clob;");
			global::java.sql.Connection_._createBlob18630 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createBlob", "()Ljava/sql/Blob;");
			global::java.sql.Connection_._setClientInfo18631 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.Connection_._setClientInfo18632 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/util/Properties;)V");
			global::java.sql.Connection_._getClientInfo18633 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getClientInfo", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.Connection_._getClientInfo18634 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getClientInfo", "()Ljava/util/Properties;");
			global::java.sql.Connection_._createArrayOf18635 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createArrayOf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Array;");
			global::java.sql.Connection_._createStruct18636 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStruct", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Struct;");
		}
	}
}
