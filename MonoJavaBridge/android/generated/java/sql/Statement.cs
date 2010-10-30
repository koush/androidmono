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
		private static global::MonoJavaBridge.MethodId _m0;
		void java.sql.Statement.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "close", "()V", ref global::java.sql.Statement_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.sql.Statement.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "isClosed", "()Z", ref global::java.sql.Statement_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[I)Z", ref global::java.sql.Statement_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.sql.Statement.execute(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;I)Z", ref global::java.sql.Statement_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.sql.Statement.execute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;)Z", ref global::java.sql.Statement_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z", ref global::java.sql.Statement_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.sql.Statement.cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "cancel", "()V", ref global::java.sql.Statement_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.sql.Statement.addBatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "addBatch", "(Ljava/lang/String;)V", ref global::java.sql.Statement_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.sql.Connection java.sql.Statement.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.Statement_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::java.sql.Statement_._m8) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.sql.ResultSet java.sql.Statement.getResultSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Statement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;", ref global::java.sql.Statement_._m9) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.sql.SQLWarning java.sql.Statement.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Statement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::java.sql.Statement_._m10) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.sql.Statement.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "clearWarnings", "()V", ref global::java.sql.Statement_._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.sql.Statement.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setFetchDirection", "(I)V", ref global::java.sql.Statement_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		int java.sql.Statement.getFetchDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getFetchDirection", "()I", ref global::java.sql.Statement_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void java.sql.Statement.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setFetchSize", "(I)V", ref global::java.sql.Statement_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		int java.sql.Statement.getFetchSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getFetchSize", "()I", ref global::java.sql.Statement_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Statement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.Statement_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I", ref global::java.sql.Statement_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I", ref global::java.sql.Statement_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		int java.sql.Statement.executeUpdate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I", ref global::java.sql.Statement_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I", ref global::java.sql.Statement_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		int java.sql.Statement.getMaxFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getMaxFieldSize", "()I", ref global::java.sql.Statement_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void java.sql.Statement.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setMaxFieldSize", "(I)V", ref global::java.sql.Statement_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		int java.sql.Statement.getMaxRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getMaxRows", "()I", ref global::java.sql.Statement_._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void java.sql.Statement.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setMaxRows", "(I)V", ref global::java.sql.Statement_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void java.sql.Statement.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setEscapeProcessing", "(Z)V", ref global::java.sql.Statement_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		int java.sql.Statement.getQueryTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getQueryTimeout", "()I", ref global::java.sql.Statement_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void java.sql.Statement.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setQueryTimeout", "(I)V", ref global::java.sql.Statement_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void java.sql.Statement.setCursorName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setCursorName", "(Ljava/lang/String;)V", ref global::java.sql.Statement_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		int java.sql.Statement.getUpdateCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getUpdateCount", "()I", ref global::java.sql.Statement_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool java.sql.Statement.getMoreResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "getMoreResults", "()Z", ref global::java.sql.Statement_._m30);
		}
		private static global::MonoJavaBridge.MethodId _m31;
		bool java.sql.Statement.getMoreResults(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "getMoreResults", "(I)Z", ref global::java.sql.Statement_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		int java.sql.Statement.getResultSetConcurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getResultSetConcurrency", "()I", ref global::java.sql.Statement_._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		int java.sql.Statement.getResultSetType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getResultSetType", "()I", ref global::java.sql.Statement_._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void java.sql.Statement.clearBatch()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "clearBatch", "()V", ref global::java.sql.Statement_._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		int[] java.sql.Statement.executeBatch()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.sql.Statement_.staticClass, "executeBatch", "()[I", ref global::java.sql.Statement_._m35) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m36;
		global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.Statement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;", ref global::java.sql.Statement_._m36) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		int java.sql.Statement.getResultSetHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Statement_.staticClass, "getResultSetHoldability", "()I", ref global::java.sql.Statement_._m37);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void java.sql.Statement.setPoolable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Statement_.staticClass, "setPoolable", "(Z)V", ref global::java.sql.Statement_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		bool java.sql.Statement.isPoolable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.Statement_.staticClass, "isPoolable", "()Z", ref global::java.sql.Statement_._m39);
		}
		static Statement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Statement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Statement"));
		}
		internal static void InitJNI()
		{
		}
	}
}
