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
		internal static global::MonoJavaBridge.MethodId _getValue22340;
		public virtual long getValue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.zip.CRC32._getValue22340);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._getValue22340);
		}
		internal static global::MonoJavaBridge.MethodId _reset22341;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._reset22341);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._reset22341);
		}
		internal static global::MonoJavaBridge.MethodId _update22342;
		public virtual void update(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update22342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _update22343;
		public virtual void update(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update22343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _update22344;
		public virtual void update(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.zip.CRC32._update22344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._update22344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CRC3222345;
		public CRC32()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CRC32.staticClass, global::java.util.zip.CRC32._CRC3222345);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CRC32.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CRC32"));
			global::java.util.zip.CRC32._getValue22340 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "getValue", "()J");
			global::java.util.zip.CRC32._reset22341 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "reset", "()V");
			global::java.util.zip.CRC32._update22342 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([B)V");
			global::java.util.zip.CRC32._update22343 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "([BII)V");
			global::java.util.zip.CRC32._update22344 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "update", "(I)V");
			global::java.util.zip.CRC32._CRC3222345 = @__env.GetMethodIDNoThrow(global::java.util.zip.CRC32.staticClass, "<init>", "()V");
		}
	}
}
