namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.Clob_))]
	public interface Clob  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Clob_ : java.lang.Object, Clob
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Clob_()
		{
			InitJNI();
		}
		internal Clob_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _length18579;
		 long java.sql.Clob.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._length18579);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._length18579);
		}
		internal static global::MonoJavaBridge.MethodId _position18580;
		 long java.sql.Clob.position(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position18580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._position18580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _position18581;
		 long java.sql.Clob.position(java.sql.Clob arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.Clob_._position18581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._position18581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _truncate18582;
		 void java.sql.Clob.truncate(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._truncate18582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._truncate18582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setString18583;
		 int java.sql.Clob.setString(long arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString18583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setString18583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString18584;
		 int java.sql.Clob.setString(long arg0, java.lang.String arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Clob_._setString18584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setString18584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _free18585;
		 void java.sql.Clob.free() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Clob_._free18585);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._free18585);
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream18586;
		 global::java.io.InputStream java.sql.Clob.getAsciiStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getAsciiStream18586)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getAsciiStream18586)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream18587;
		 global::java.io.Reader java.sql.Clob.getCharacterStream(long arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream18587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getCharacterStream18587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream18588;
		 global::java.io.Reader java.sql.Clob.getCharacterStream() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getCharacterStream18588)) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getCharacterStream18588)) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18589;
		 global::java.io.OutputStream java.sql.Clob.setAsciiStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setAsciiStream18589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setAsciiStream18589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18590;
		 global::java.io.Writer java.sql.Clob.setCharacterStream(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._setCharacterStream18590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Writer;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._setCharacterStream18590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Writer;
		}
		internal static global::MonoJavaBridge.MethodId _getSubString18591;
		 global::java.lang.String java.sql.Clob.getSubString(long arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Clob_._getSubString18591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Clob_.staticClass, global::java.sql.Clob_._getSubString18591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Clob_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Clob"));
			global::java.sql.Clob_._length18579 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "length", "()J");
			global::java.sql.Clob_._position18580 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/lang/String;J)J");
			global::java.sql.Clob_._position18581 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "position", "(Ljava/sql/Clob;J)J");
			global::java.sql.Clob_._truncate18582 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "truncate", "(J)V");
			global::java.sql.Clob_._setString18583 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;)I");
			global::java.sql.Clob_._setString18584 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setString", "(JLjava/lang/String;II)I");
			global::java.sql.Clob_._free18585 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "free", "()V");
			global::java.sql.Clob_._getAsciiStream18586 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getAsciiStream", "()Ljava/io/InputStream;");
			global::java.sql.Clob_._getCharacterStream18587 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "(JJ)Ljava/io/Reader;");
			global::java.sql.Clob_._getCharacterStream18588 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getCharacterStream", "()Ljava/io/Reader;");
			global::java.sql.Clob_._setAsciiStream18589 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setAsciiStream", "(J)Ljava/io/OutputStream;");
			global::java.sql.Clob_._setCharacterStream18590 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "setCharacterStream", "(J)Ljava/io/Writer;");
			global::java.sql.Clob_._getSubString18591 = @__env.GetMethodIDNoThrow(global::java.sql.Clob_.staticClass, "getSubString", "(JI)Ljava/lang/String;");
		}
	}
}
