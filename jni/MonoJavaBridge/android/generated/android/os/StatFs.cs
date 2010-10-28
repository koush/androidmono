namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StatFs : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StatFs(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize10202;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.StatFs._finalize10202);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._finalize10202);
		}
		internal static global::MonoJavaBridge.MethodId _restat10203;
		public virtual void restat(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.StatFs._restat10203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._restat10203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int BlockSize
		{
			get
			{
				return getBlockSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockSize10204;
		public virtual int getBlockSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getBlockSize10204);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockSize10204);
		}
		public new int BlockCount
		{
			get
			{
				return getBlockCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBlockCount10205;
		public virtual int getBlockCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getBlockCount10205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getBlockCount10205);
		}
		public new int FreeBlocks
		{
			get
			{
				return getFreeBlocks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFreeBlocks10206;
		public virtual int getFreeBlocks()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getFreeBlocks10206);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getFreeBlocks10206);
		}
		public new int AvailableBlocks
		{
			get
			{
				return getAvailableBlocks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAvailableBlocks10207;
		public virtual int getAvailableBlocks()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.StatFs._getAvailableBlocks10207);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.StatFs.staticClass, global::android.os.StatFs._getAvailableBlocks10207);
		}
		internal static global::MonoJavaBridge.MethodId _StatFs10208;
		public StatFs(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.StatFs.staticClass, global::android.os.StatFs._StatFs10208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StatFs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.StatFs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/StatFs"));
			global::android.os.StatFs._finalize10202 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "finalize", "()V");
			global::android.os.StatFs._restat10203 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "restat", "(Ljava/lang/String;)V");
			global::android.os.StatFs._getBlockSize10204 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getBlockSize", "()I");
			global::android.os.StatFs._getBlockCount10205 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getBlockCount", "()I");
			global::android.os.StatFs._getFreeBlocks10206 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getFreeBlocks", "()I");
			global::android.os.StatFs._getAvailableBlocks10207 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "getAvailableBlocks", "()I");
			global::android.os.StatFs._StatFs10208 = @__env.GetMethodIDNoThrow(global::android.os.StatFs.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
