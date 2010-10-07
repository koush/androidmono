namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class YuvImage : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static YuvImage()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.YuvImage), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.YuvImage(@__env);
			}
		}
		protected YuvImage(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3631;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.YuvImage._getWidth3631);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getWidth3631);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3632;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.YuvImage._getHeight3632);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getHeight3632);
		}
		internal static global::net.sf.jni4net.jni.MethodId _compressToJpeg3633;
		public virtual bool compressToJpeg(android.graphics.Rect arg0, int arg1, java.io.OutputStream arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.YuvImage._compressToJpeg3633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._compressToJpeg3633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYuvData3634;
		public virtual byte[] getYuvData() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.YuvImage._getYuvData3634));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getYuvData3634));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getYuvFormat3635;
		public virtual int getYuvFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.YuvImage._getYuvFormat3635);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getYuvFormat3635);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStrides3636;
		public virtual int[] getStrides() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.YuvImage._getStrides3636));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._getStrides3636));
		}
		internal static global::net.sf.jni4net.jni.MethodId _YuvImage3637;
		public YuvImage(byte[] arg0, int arg1, int arg2, int arg3, int[] arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.YuvImage.staticClass, global::android.graphics.YuvImage._YuvImage3637, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.YuvImage.staticClass = @__class;
			global::android.graphics.YuvImage._getWidth3631 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "getWidth", "()I");
			global::android.graphics.YuvImage._getHeight3632 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "getHeight", "()I");
			global::android.graphics.YuvImage._compressToJpeg3633 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "compressToJpeg", "(Landroid/graphics/Rect;ILjava/io/OutputStream;)Z");
			global::android.graphics.YuvImage._getYuvData3634 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "getYuvData", "()[B");
			global::android.graphics.YuvImage._getYuvFormat3635 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "getYuvFormat", "()I");
			global::android.graphics.YuvImage._getStrides3636 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "getStrides", "()[I");
			global::android.graphics.YuvImage._YuvImage3637 = @__env.GetMethodID(global::android.graphics.YuvImage.staticClass, "<init>", "([BIII[I)V");
		}
	}
}
