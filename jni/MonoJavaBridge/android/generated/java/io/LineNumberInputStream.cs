namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LineNumberInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LineNumberInputStream()
		{
			InitJNI();
		}
		protected LineNumberInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int LineNumber
		{
			get
			{
				return getLineNumber();
			}
			set
			{
				setLineNumber(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLineNumber19004;
		public virtual int getLineNumber() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._getLineNumber19004);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._getLineNumber19004);
		}
		internal static global::MonoJavaBridge.MethodId _mark19005;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._mark19005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._mark19005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset19006;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._reset19006);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._reset19006);
		}
		internal static global::MonoJavaBridge.MethodId _read19007;
		public override int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._read19007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read19007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read19008;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._read19008);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._read19008);
		}
		internal static global::MonoJavaBridge.MethodId _skip19009;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.LineNumberInputStream._skip19009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._skip19009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _available19010;
		public override int available() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream._available19010);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._available19010);
		}
		internal static global::MonoJavaBridge.MethodId _setLineNumber19011;
		public virtual void setLineNumber(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream._setLineNumber19011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._setLineNumber19011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LineNumberInputStream19012;
		public LineNumberInputStream(java.io.InputStream arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.LineNumberInputStream.staticClass, global::java.io.LineNumberInputStream._LineNumberInputStream19012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.LineNumberInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/LineNumberInputStream"));
			global::java.io.LineNumberInputStream._getLineNumber19004 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "getLineNumber", "()I");
			global::java.io.LineNumberInputStream._mark19005 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "mark", "(I)V");
			global::java.io.LineNumberInputStream._reset19006 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "reset", "()V");
			global::java.io.LineNumberInputStream._read19007 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "([BII)I");
			global::java.io.LineNumberInputStream._read19008 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "read", "()I");
			global::java.io.LineNumberInputStream._skip19009 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "skip", "(J)J");
			global::java.io.LineNumberInputStream._available19010 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "available", "()I");
			global::java.io.LineNumberInputStream._setLineNumber19011 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "setLineNumber", "(I)V");
			global::java.io.LineNumberInputStream._LineNumberInputStream19012 = @__env.GetMethodIDNoThrow(global::java.io.LineNumberInputStream.staticClass, "<init>", "(Ljava/io/InputStream;)V");
		}
	}
}
