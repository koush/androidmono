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
		internal static global::MonoJavaBridge.MethodId _length24307;
		long java.sql.Clob.length()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "length", "()J", ref global::java.sql.Clob_._length24307);
		}
		internal static global::MonoJavaBridge.MethodId _position24308;
		long java.sql.Clob.position(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "position", "(Ljava/lang/String;J)J", ref global::java.sql.Clob_._position24308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position24309;
		long java.sql.Clob.position(java.sql.Clob arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.sql.Clob_.staticClass, "position", "(Ljava/sql/Clob;J)J", ref global::java.sql.Clob_._position24309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate24310;
		void java.sql.Clob.truncate(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Clob_.staticClass, "truncate", "(J)V", ref global::java.sql.Clob_._truncate24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setString24311;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;)I", ref global::java.sql.Clob_._setString24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString24312;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;II)I", ref global::java.sql.Clob_._setString24312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _free24313;
		void java.sql.Clob.free()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.Clob_.staticClass, "free", "()V", ref global::java.sql.Clob_._free24313);
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream24314;
		global::java.io.InputStream java.sql.Clob.getAsciiStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getAsciiStream", "()Ljava/io/InputStream;", ref global::java.sql.Clob_._getAsciiStream24314) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24315;
		global::java.io.Reader java.sql.Clob.getCharacterStream(long arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getCharacterStream", "(JJ)Ljava/io/Reader;", ref global::java.sql.Clob_._getCharacterStream24315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24316;
		global::java.io.Reader java.sql.Clob.getCharacterStream()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "getCharacterStream", "()Ljava/io/Reader;", ref global::java.sql.Clob_._getCharacterStream24316) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24317;
		global::java.io.OutputStream java.sql.Clob.setAsciiStream(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "setAsciiStream", "(J)Ljava/io/OutputStream;", ref global::java.sql.Clob_._setAsciiStream24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24318;
		global::java.io.Writer java.sql.Clob.setCharacterStream(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.Clob_.staticClass, "setCharacterStream", "(J)Ljava/io/Writer;", ref global::java.sql.Clob_._setCharacterStream24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _getSubString24319;
		global::java.lang.String java.sql.Clob.getSubString(long arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.sql.Clob_.staticClass, "getSubString", "(JI)Ljava/lang/String;", ref global::java.sql.Clob_._getSubString24319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		static Clob_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Clob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Clob"));
		}
		internal static void InitJNI()
		{
		}
	}
}
