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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._length24307);
		}
		internal static global::MonoJavaBridge.MethodId _position24308;
		long java.sql.Clob.position(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position24308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position24309;
		long java.sql.Clob.position(java.sql.Clob arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position24309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate24310;
		void java.sql.Clob.truncate(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._truncate24310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setString24311;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString24311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString24312;
		int java.sql.Clob.setString(long arg0, java.lang.String arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString24312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _free24313;
		void java.sql.Clob.free()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._free24313);
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream24314;
		global::java.io.InputStream java.sql.Clob.getAsciiStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getAsciiStream24314)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24315;
		global::java.io.Reader java.sql.Clob.getCharacterStream(long arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream24315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24316;
		global::java.io.Reader java.sql.Clob.getCharacterStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream24316)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24317;
		global::java.io.OutputStream java.sql.Clob.setAsciiStream(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setAsciiStream24317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24318;
		global::java.io.Writer java.sql.Clob.setCharacterStream(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setCharacterStream24318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _getSubString24319;
		global::java.lang.String java.sql.Clob.getSubString(long arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getSubString24319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		static Clob_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Clob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Clob"));
			global::java.sql.Clob_._length24307 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "length", "()J");
			global::java.sql.Clob_._position24308 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/lang/String;J)J");
			global::java.sql.Clob_._position24309 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/sql/Clob;J)J");
			global::java.sql.Clob_._truncate24310 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "truncate", "(J)V");
			global::java.sql.Clob_._setString24311 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;)I");
			global::java.sql.Clob_._setString24312 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;II)I");
			global::java.sql.Clob_._free24313 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "free", "()V");
			global::java.sql.Clob_._getAsciiStream24314 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.Clob_._getCharacterStream24315 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "(JJ)Ljava/io/Reader;");
			global::java.sql.Clob_._getCharacterStream24316 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.Clob_._setAsciiStream24317 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setAsciiStream", "(J)Ljava/io/OutputStream;");
			global::java.sql.Clob_._setCharacterStream24318 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setCharacterStream", "(J)Ljava/io/Writer;");
			global::java.sql.Clob_._getSubString24319 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getSubString", "(JI)Ljava/lang/String;");
		}
		internal static void InitJNI()
		{
		}
	}
}
