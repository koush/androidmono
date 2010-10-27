namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CRC32 : java.lang.Object, Checksum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CRC32()
		{
			InitJNI();
		}
		protected CRC32(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new long Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue28332;
		public virtual long getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.CRC32._getValue28332);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._getValue28332);
		}
		internal static global::MonoJavaBridge.MethodId _reset28333;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._reset28333);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._reset28333);
		}
		internal static global::MonoJavaBridge.MethodId _update28334;
		public virtual void update(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update28335;
		public virtual void update(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update28336;
		public virtual void update(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update28336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update28336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CRC3228337;
		public CRC32() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._CRC3228337);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CRC32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CRC32"));
			global::java.util.zip.CRC32._getValue28332 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "getValue", "()J");
			global::java.util.zip.CRC32._reset28333 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "reset", "()V");
			global::java.util.zip.CRC32._update28334 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([B)V");
			global::java.util.zip.CRC32._update28335 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([BII)V");
			global::java.util.zip.CRC32._update28336 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "(I)V");
			global::java.util.zip.CRC32._CRC3228337 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "<init>", "()V");
		}
	}
}
