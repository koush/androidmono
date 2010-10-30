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
		private static global::MonoJavaBridge.MethodId _m0;
		void java.sql.Connection.setReadOnly(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setReadOnly", "(Z)V", ref global::java.sql.Connection_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.sql.Connection.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "close", "()V", ref global::java.sql.Connection_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.sql.Connection.isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Connection_.staticClass, "isReadOnly", "()Z", ref global::java.sql.Connection_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.sql.Connection.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Connection_.staticClass, "isClosed", "()Z", ref global::java.sql.Connection_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.sql.Connection.isValid(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Connection_.staticClass, "isValid", "(I)Z", ref global::java.sql.Connection_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.sql.Connection.commit()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "commit", "()V", ref global::java.sql.Connection_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::java.sql.SQLWarning java.sql.Connection.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Connection_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::java.sql.Connection_._m6) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.sql.Connection.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "clearWarnings", "()V", ref global::java.sql.Connection_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.sql.DatabaseMetaData java.sql.Connection.getMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.DatabaseMetaData>(this, global::java.sql.Connection_.staticClass, "getMetaData", "()Ljava/sql/DatabaseMetaData;", ref global::java.sql.Connection_._m8) as java.sql.DatabaseMetaData;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		int java.sql.Connection.getHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Connection_.staticClass, "getHoldability", "()I", ref global::java.sql.Connection_._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Statement>(this, global::java.sql.Connection_.staticClass, "createStatement", "(III)Ljava/sql/Statement;", ref global::java.sql.Connection_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.Statement;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.sql.Statement java.sql.Connection.createStatement(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Statement>(this, global::java.sql.Connection_.staticClass, "createStatement", "(II)Ljava/sql/Statement;", ref global::java.sql.Connection_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Statement;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.sql.Statement java.sql.Connection.createStatement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Statement>(this, global::java.sql.Connection_.staticClass, "createStatement", "()Ljava/sql/Statement;", ref global::java.sql.Connection_._m12) as java.sql.Statement;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;I)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;[I)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;II)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		global::java.sql.PreparedStatement java.sql.Connection.prepareStatement(java.lang.String arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.PreparedStatement>(this, global::java.sql.Connection_.staticClass, "prepareStatement", "(Ljava/lang/String;III)Ljava/sql/PreparedStatement;", ref global::java.sql.Connection_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.PreparedStatement;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.CallableStatement>(this, global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;II)Ljava/sql/CallableStatement;", ref global::java.sql.Connection_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.sql.CallableStatement;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.CallableStatement>(this, global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;III)Ljava/sql/CallableStatement;", ref global::java.sql.Connection_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as java.sql.CallableStatement;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		global::java.sql.CallableStatement java.sql.Connection.prepareCall(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.CallableStatement>(this, global::java.sql.Connection_.staticClass, "prepareCall", "(Ljava/lang/String;)Ljava/sql/CallableStatement;", ref global::java.sql.Connection_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.CallableStatement;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		global::java.lang.String java.sql.Connection.nativeSQL(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Connection_.staticClass, "nativeSQL", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.sql.Connection_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void java.sql.Connection.setAutoCommit(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setAutoCommit", "(Z)V", ref global::java.sql.Connection_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		bool java.sql.Connection.getAutoCommit()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Connection_.staticClass, "getAutoCommit", "()Z", ref global::java.sql.Connection_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void java.sql.Connection.rollback(java.sql.Savepoint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "rollback", "(Ljava/sql/Savepoint;)V", ref global::java.sql.Connection_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void java.sql.Connection.rollback()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "rollback", "()V", ref global::java.sql.Connection_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void java.sql.Connection.setCatalog(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setCatalog", "(Ljava/lang/String;)V", ref global::java.sql.Connection_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		global::java.lang.String java.sql.Connection.getCatalog()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Connection_.staticClass, "getCatalog", "()Ljava/lang/String;", ref global::java.sql.Connection_._m28) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void java.sql.Connection.setTransactionIsolation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setTransactionIsolation", "(I)V", ref global::java.sql.Connection_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		int java.sql.Connection.getTransactionIsolation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Connection_.staticClass, "getTransactionIsolation", "()I", ref global::java.sql.Connection_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		global::java.util.Map java.sql.Connection.getTypeMap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::java.sql.Connection_.staticClass, "getTypeMap", "()Ljava/util/Map;", ref global::java.sql.Connection_._m31) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void java.sql.Connection.setTypeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setTypeMap", "(Ljava/util/Map;)V", ref global::java.sql.Connection_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void java.sql.Connection.setHoldability(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setHoldability", "(I)V", ref global::java.sql.Connection_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		global::java.sql.Savepoint java.sql.Connection.setSavepoint()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Savepoint>(this, global::java.sql.Connection_.staticClass, "setSavepoint", "()Ljava/sql/Savepoint;", ref global::java.sql.Connection_._m34) as java.sql.Savepoint;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		global::java.sql.Savepoint java.sql.Connection.setSavepoint(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Savepoint>(this, global::java.sql.Connection_.staticClass, "setSavepoint", "(Ljava/lang/String;)Ljava/sql/Savepoint;", ref global::java.sql.Connection_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Savepoint;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void java.sql.Connection.releaseSavepoint(java.sql.Savepoint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "releaseSavepoint", "(Ljava/sql/Savepoint;)V", ref global::java.sql.Connection_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		global::java.sql.Clob java.sql.Connection.createClob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::java.sql.Connection_.staticClass, "createClob", "()Ljava/sql/Clob;", ref global::java.sql.Connection_._m37) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		global::java.sql.Blob java.sql.Connection.createBlob()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::java.sql.Connection_.staticClass, "createBlob", "()Ljava/sql/Blob;", ref global::java.sql.Connection_._m38) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void java.sql.Connection.setClientInfo(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::java.sql.Connection_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void java.sql.Connection.setClientInfo(java.util.Properties arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Connection_.staticClass, "setClientInfo", "(Ljava/util/Properties;)V", ref global::java.sql.Connection_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		global::java.lang.String java.sql.Connection.getClientInfo(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Connection_.staticClass, "getClientInfo", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.sql.Connection_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		global::java.util.Properties java.sql.Connection.getClientInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Connection_.staticClass, "getClientInfo", "()Ljava/util/Properties;", ref global::java.sql.Connection_._m42) as java.util.Properties;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		global::java.sql.Array java.sql.Connection.createArrayOf(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::java.sql.Connection_.staticClass, "createArrayOf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Array;", ref global::java.sql.Connection_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		global::java.sql.Struct java.sql.Connection.createStruct(java.lang.String arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Struct>(this, global::java.sql.Connection_.staticClass, "createStruct", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/sql/Struct;", ref global::java.sql.Connection_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Struct;
		}
		static Connection_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Connection_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Connection"));
		}
		internal static void InitJNI()
		{
		}
	}
}
