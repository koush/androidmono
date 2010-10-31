namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Clob_))]
	public partial interface Clob  : global::MonoJavaBridge.IJavaObject 
	{
		long length();
		long position(java.lang.String arg0, long arg1);
		long position(java.sql.Clob arg0, long arg1);
		void truncate(long arg0);
		int setString(long arg0, java.lang.String arg1);
		int setString(long arg0, java.lang.String arg1, int arg2, int arg3);
		void free();
		global::java.io.InputStream getAsciiStream();
		global::java.io.Reader getCharacterStream(long arg0, long arg1);
		global::java.io.Reader getCharacterStream();
		global::java.io.OutputStream setAsciiStream(long arg0);
		global::java.io.Writer setCharacterStream(long arg0);
		global::java.lang.String getSubString(long arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.Clob))]
	internal sealed partial class Clob_ : java.lang.Object, Clob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Clob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long java.sql.Clob.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "length", "()J", ref global::java.sql.Clob_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		long java.sql.Clob.position(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "position", "(Ljava/lang/String;J)J", ref global::java.sql.Clob_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		long java.sql.Clob.position(java.sql.Clob arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "position", "(Ljava/sql/Clob;J)J", ref global::java.sql.Clob_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.sql.Clob.truncate(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Clob_.staticClass, "truncate", "(J)V", ref global::java.sql.Clob_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;)I", ref global::java.sql.Clob_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;II)I", ref global::java.sql.Clob_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.sql.Clob.free()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Clob_.staticClass, "free", "()V", ref global::java.sql.Clob_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.io.InputStream java.sql.Clob.getAsciiStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getAsciiStream", "()Ljava/io/InputStream;", ref global::java.sql.Clob_._m7) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		global::java.io.Reader java.sql.Clob.getCharacterStream(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getCharacterStream", "(JJ)Ljava/io/Reader;", ref global::java.sql.Clob_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		global::java.io.Reader java.sql.Clob.getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getCharacterStream", "()Ljava/io/Reader;", ref global::java.sql.Clob_._m9) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		global::java.io.OutputStream java.sql.Clob.setAsciiStream(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "setAsciiStream", "(J)Ljava/io/OutputStream;", ref global::java.sql.Clob_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		global::java.io.Writer java.sql.Clob.setCharacterStream(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "setCharacterStream", "(J)Ljava/io/Writer;", ref global::java.sql.Clob_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Writer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.String java.sql.Clob.getSubString(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Clob_.staticClass, "getSubString", "(JI)Ljava/lang/String;", ref global::java.sql.Clob_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		static Clob_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Clob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Clob"));
		}
	}
}
