namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class YuvImage : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static YuvImage()
		{
			InitJNI();
		}
		protected YuvImage(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Width
		{
			get
			{
				return getWidth();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWidth5808;
		public virtual int getWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.YuvImage._getWidth5808);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getWidth5808);
		}
		public new int Height
		{
			get
			{
				return getHeight();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHeight5809;
		public virtual int getHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.YuvImage._getHeight5809);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getHeight5809);
		}
		internal static global::MonoJavaBridge.MethodId _compressToJpeg5810;
		public virtual bool compressToJpeg(android.graphics.Rect arg0, int arg1, java.io.OutputStream arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.YuvImage._compressToJpeg5810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._compressToJpeg5810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new byte[] YuvData
		{
			get
			{
				return getYuvData();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYuvData5811;
		public virtual byte[] getYuvData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.YuvImage._getYuvData5811)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getYuvData5811)) as byte[];
		}
		public new int YuvFormat
		{
			get
			{
				return getYuvFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYuvFormat5812;
		public virtual int getYuvFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.YuvImage._getYuvFormat5812);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getYuvFormat5812);
		}
		public new int[] Strides
		{
			get
			{
				return getStrides();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStrides5813;
		public virtual int[] getStrides() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.YuvImage._getStrides5813)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getStrides5813)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _YuvImage5814;
		public YuvImage(byte[] arg0, int arg1, int arg2, int arg3, int[] arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._YuvImage5814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.YuvImage.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/YuvImage"));
			global::android.graphics.YuvImage._getWidth5808 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "getWidth", "()I");
			global::android.graphics.YuvImage._getHeight5809 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "getHeight", "()I");
			global::android.graphics.YuvImage._compressToJpeg5810 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "compressToJpeg", "(Landroid/graphics/Rect;ILjava/io/OutputStream;)Z");
			global::android.graphics.YuvImage._getYuvData5811 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "getYuvData", "()[B");
			global::android.graphics.YuvImage._getYuvFormat5812 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "getYuvFormat", "()I");
			global::android.graphics.YuvImage._getStrides5813 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "getStrides", "()[I");
			global::android.graphics.YuvImage._YuvImage5814 = @__env.GetMethodIDNoThrow(global::android.graphics.YuvImage.staticClass, "<init>", "([BIII[I)V");
		}
	}
}
