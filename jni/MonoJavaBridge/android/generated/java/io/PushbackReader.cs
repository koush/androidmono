namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PushbackReader : java.io.FilterReader
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PushbackReader()
		{
			InitJNI();
		}
		protected PushbackReader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close13879;
		public override void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._close13879);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._close13879);
		}
		internal static global::MonoJavaBridge.MethodId _mark13880;
		public override void mark(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._mark13880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._mark13880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset13881;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._reset13881);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._reset13881);
		}
		internal static global::MonoJavaBridge.MethodId _read13882;
		public override int read() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read13882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read13882);
		}
		internal static global::MonoJavaBridge.MethodId _read13883;
		public override int read(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.io.PushbackReader._read13883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._read13883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip13884;
		public override long skip(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.io.PushbackReader._skip13884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._skip13884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markSupported13885;
		public override bool markSupported() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._markSupported13885);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._markSupported13885);
		}
		internal static global::MonoJavaBridge.MethodId _ready13886;
		public override bool ready() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.io.PushbackReader._ready13886);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._ready13886);
		}
		internal static global::MonoJavaBridge.MethodId _unread13887;
		public virtual void unread(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread13887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread13887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unread13888;
		public virtual void unread(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread13888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread13888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unread13889;
		public virtual void unread(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.io.PushbackReader._unread13889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.io.PushbackReader.staticClass, global::java.io.PushbackReader._unread13889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader13890;
		public PushbackReader(java.io.Reader arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader13890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PushbackReader13891;
		public PushbackReader(java.io.Reader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.PushbackReader.staticClass, global::java.io.PushbackReader._PushbackReader13891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.PushbackReader.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/PushbackReader"));
			global::java.io.PushbackReader._close13879 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "close", "()V");
			global::java.io.PushbackReader._mark13880 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "mark", "(I)V");
			global::java.io.PushbackReader._reset13881 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "reset", "()V");
			global::java.io.PushbackReader._read13882 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "()I");
			global::java.io.PushbackReader._read13883 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "read", "([CII)I");
			global::java.io.PushbackReader._skip13884 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "skip", "(J)J");
			global::java.io.PushbackReader._markSupported13885 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "markSupported", "()Z");
			global::java.io.PushbackReader._ready13886 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "ready", "()Z");
			global::java.io.PushbackReader._unread13887 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([C)V");
			global::java.io.PushbackReader._unread13888 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "([CII)V");
			global::java.io.PushbackReader._unread13889 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "unread", "(I)V");
			global::java.io.PushbackReader._PushbackReader13890 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;I)V");
			global::java.io.PushbackReader._PushbackReader13891 = @__env.GetMethodIDNoThrow(global::java.io.PushbackReader.staticClass, "<init>", "(Ljava/io/Reader;)V");
		}
	}
}
