namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Adler32 : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Adler32()
		{
			InitJNI();
		}
		protected Adler32(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new long Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue28327;
		public virtual long getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.Adler32._getValue28327);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._getValue28327);
		}
		internal static global::MonoJavaBridge.MethodId _reset28328;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._reset28328);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._reset28328);
		}
		internal static global::MonoJavaBridge.MethodId _update28329;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28330;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28331;
		public virtual void update(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.Adler32._update28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._update28331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Adler3228332;
		public Adler32() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.Adler32.staticClass, global::java.util.zip.Adler32._Adler3228332);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.Adler32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/Adler32"));
			global::java.util.zip.Adler32._getValue28327 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "getValue", "()J");
			global::java.util.zip.Adler32._reset28328 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "reset", "()V");
			global::java.util.zip.Adler32._update28329 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "([B)V");
			global::java.util.zip.Adler32._update28330 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "([BII)V");
			global::java.util.zip.Adler32._update28331 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "update", "(I)V");
			global::java.util.zip.Adler32._Adler3228332 = @__env.GetMethodIDNoThrow(global::java.util.zip.Adler32.staticClass, "<init>", "()V");
		}
	}
}
