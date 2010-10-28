namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Connection_))]
	public partial interface Connection  : global::MonoJavaBridge.IJavaObject 
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
	internal sealed partial class Connection_ : java.lang.Object, Connection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Connection_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly24320;
		void java.sql.Connection.setReadOnly(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setReadOnly24320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setReadOnly24320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close24321;
		void java.sql.Connection.close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._close24321);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._close24321);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly24322;
		bool java.sql.Connection.isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isReadOnly24322);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isReadOnly24322);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24323;
		bool java.sql.Connection.isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isClosed24323);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isClosed24323);
		}
		internal static global::MonoJavaBridge.MethodId _isValid24324;
		bool java.sql.Connection.isValid(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._isValid24324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._isValid24324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _commit24325;
		void java.sql.Connection.commit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._commit24325);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._commit24325);
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24326;
		global::java.sql.SQLWarning java.sql.Connection.getWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getWarnings24326)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getWarnings24326)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24327;
		void java.sql.Connection.clearWarnings()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._clearWarnings24327);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._clearWarnings24327);
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24328;
		global::java.sql.DatabaseMetaData java.sql.Connection.getMetaData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.DatabaseMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getMetaData24328)) as java.sql.DatabaseMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.DatabaseMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getMetaData24328)) as java.sql.DatabaseMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability24329;
		int java.sql.Connection.getHoldability()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Connection_._getHoldability24329);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getHoldability24329);
		}
		internal static global::MonoJavaBridge.MethodId _createStatement24330;
		global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement24330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement24330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _createStatement24331;
		global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement24331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement24331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _createStatement24332;
		global::java.sql.Statement java.sql.Connection.createStatement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStatement24332)) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStatement24332)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24333;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24334;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24335;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, java.lang.String[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24336;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24337;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareStatement24338;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareStatement24338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.PreparedStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.PreparedStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareStatement24338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.PreparedStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall24339;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall24339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall24339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall24340;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall24340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall24340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _prepareCall24341;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._prepareCall24341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.CallableStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.CallableStatement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._prepareCall24341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.CallableStatement;
		}
		internal static global::MonoJavaBridge.MethodId _nativeSQL24342;
		global::java.lang.String java.sql.Connection.nativeSQL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._nativeSQL24342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._nativeSQL24342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAutoCommit24343;
		void java.sql.Connection.setAutoCommit(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setAutoCommit24343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setAutoCommit24343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAutoCommit24344;
		bool java.sql.Connection.getAutoCommit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.Connection_._getAutoCommit24344);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getAutoCommit24344);
		}
		internal static global::MonoJavaBridge.MethodId _rollback24345;
		void java.sql.Connection.rollback(java.sql.Savepoint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._rollback24345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._rollback24345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rollback24346;
		void java.sql.Connection.rollback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._rollback24346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._rollback24346);
		}
		internal static global::MonoJavaBridge.MethodId _setCatalog24347;
		void java.sql.Connection.setCatalog(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setCatalog24347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setCatalog24347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCatalog24348;
		global::java.lang.String java.sql.Connection.getCatalog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getCatalog24348)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getCatalog24348)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionIsolation24349;
		void java.sql.Connection.setTransactionIsolation(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setTransactionIsolation24349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setTransactionIsolation24349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransactionIsolation24350;
		int java.sql.Connection.getTransactionIsolation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Connection_._getTransactionIsolation24350);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getTransactionIsolation24350);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeMap24351;
		global::java.util.Map java.sql.Connection.getTypeMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getTypeMap24351)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getTypeMap24351)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeMap24352;
		void java.sql.Connection.setTypeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setTypeMap24352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setTypeMap24352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHoldability24353;
		void java.sql.Connection.setHoldability(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setHoldability24353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setHoldability24353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSavepoint24354;
		global::java.sql.Savepoint java.sql.Connection.setSavepoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._setSavepoint24354)) as java.sql.Savepoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setSavepoint24354)) as java.sql.Savepoint;
		}
		internal static global::MonoJavaBridge.MethodId _setSavepoint24355;
		global::java.sql.Savepoint java.sql.Connection.setSavepoint(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._setSavepoint24355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Savepoint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Savepoint>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setSavepoint24355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Savepoint;
		}
		internal static global::MonoJavaBridge.MethodId _releaseSavepoint24356;
		void java.sql.Connection.releaseSavepoint(java.sql.Savepoint arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._releaseSavepoint24356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._releaseSavepoint24356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createClob24357;
		global::java.sql.Clob java.sql.Connection.createClob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createClob24357)) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createClob24357)) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _createBlob24358;
		global::java.sql.Blob java.sql.Connection.createBlob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createBlob24358)) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createBlob24358)) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _setClientInfo24359;
		void java.sql.Connection.setClientInfo(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setClientInfo24359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setClientInfo24359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClientInfo24360;
		void java.sql.Connection.setClientInfo(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Connection_._setClientInfo24360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._setClientInfo24360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfo24361;
		global::java.lang.String java.sql.Connection.getClientInfo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getClientInfo24361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getClientInfo24361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getClientInfo24362;
		global::java.util.Properties java.sql.Connection.getClientInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._getClientInfo24362)) as java.util.Properties;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._getClientInfo24362)) as java.util.Properties;
		}
		internal static global::MonoJavaBridge.MethodId _createArrayOf24363;
		global::java.sql.Array java.sql.Connection.createArrayOf(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createArrayOf24363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createArrayOf24363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _createStruct24364;
		global::java.sql.Struct java.sql.Connection.createStruct(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Struct>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Connection_._createStruct24364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Struct;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Struct>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Connection_.staticClass, global::java.sql.Connection_._createStruct24364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Struct;
		}
		static Connection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Connection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Connection"));
			global::java.sql.Connection_._setReadOnly24320 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setReadOnly", "(Z)V");
			global::java.sql.Connection_._close24321 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "close", "()V");
			global::java.sql.Connection_._isReadOnly24322 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isReadOnly", "()Z");
			global::java.sql.Connection_._isClosed24323 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isClosed", "()Z");
			global::java.sql.Connection_._isValid24324 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "isValid", "(I)Z");
			global::java.sql.Connection_._commit24325 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "commit", "()V");
			global::java.sql.Connection_._getWarnings24326 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.Connection_._clearWarnings24327 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "clearWarnings", "()V");
			global::java.sql.Connection_._getMetaData24328 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getMetaData", "()Ljava/sql/DatabaseMetaData;");
			global::java.sql.Connection_._getHoldability24329 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getHoldability", "()I");
			global::java.sql.Connection_._createStatement24330 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "(III)Ljava/sql/Statement;");
			global::java.sql.Connection_._createStatement24331 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "(II)Ljava/sql/Statement;");
			global::java.sql.Connection_._createStatement24332 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStatement", "()Ljava/sql/Statement;");
			global::java.sql.Connection_._prepareStatement24333 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;I)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement24334 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement24335 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement24336 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[I)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement24337 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;II)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareStatement24338 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;III)Ljava/sql/PreparedStatement;");
			global::java.sql.Connection_._prepareCall24339 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;II)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._prepareCall24340 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;III)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._prepareCall24341 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;)Ljava/sql/CallableStatement;");
			global::java.sql.Connection_._nativeSQL24342 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "nativeSQL", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.Connection_._setAutoCommit24343 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setAutoCommit", "(Z)V");
			global::java.sql.Connection_._getAutoCommit24344 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getAutoCommit", "()Z");
			global::java.sql.Connection_._rollback24345 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "rollback", "(Ljava/sql/Savepoint;)V");
			global::java.sql.Connection_._rollback24346 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "rollback", "()V");
			global::java.sql.Connection_._setCatalog24347 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setCatalog", "(Ljava/lang/String;)V");
			global::java.sql.Connection_._getCatalog24348 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getCatalog", "()Ljava/lang/String;");
			global::java.sql.Connection_._setTransactionIsolation24349 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setTransactionIsolation", "(I)V");
			global::java.sql.Connection_._getTransactionIsolation24350 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getTransactionIsolation", "()I");
			global::java.sql.Connection_._getTypeMap24351 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getTypeMap", "()Ljava/util/Map;");
			global::java.sql.Connection_._setTypeMap24352 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setTypeMap", "(Ljava/util/Map;)V");
			global::java.sql.Connection_._setHoldability24353 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setHoldability", "(I)V");
			global::java.sql.Connection_._setSavepoint24354 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setSavepoint", "()Ljava/sql/Savepoint;");
			global::java.sql.Connection_._setSavepoint24355 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setSavepoint", "(Ljava/lang/String;)Ljava/sql/Savepoint;");
			global::java.sql.Connection_._releaseSavepoint24356 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "releaseSavepoint", "(Ljava/sql/Savepoint;)V");
			global::java.sql.Connection_._createClob24357 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createClob", "()Ljava/sql/Clob;");
			global::java.sql.Connection_._createBlob24358 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createBlob", "()Ljava/sql/Blob;");
			global::java.sql.Connection_._setClientInfo24359 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.Connection_._setClientInfo24360 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/util/Properties;)V");
			global::java.sql.Connection_._getClientInfo24361 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getClientInfo", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.Connection_._getClientInfo24362 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "getClientInfo", "()Ljava/util/Properties;");
			global::java.sql.Connection_._createArrayOf24363 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createArrayOf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Array;");
			global::java.sql.Connection_._createStruct24364 = @__env.GetMethodIDNoThrow(global::java.sql.Connection_.staticClass, "createStruct", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Struct;");
		}
		internal static void InitJNI()
		{
		}
	}
}
