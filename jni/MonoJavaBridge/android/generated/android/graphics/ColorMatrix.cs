namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ColorMatrix : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ColorMatrix()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.ColorMatrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.ColorMatrix(@__env);
			}
		}
		protected ColorMatrix(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getArray3108;
		public virtual float[] getArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.ColorMatrix._getArray3108));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._getArray3108));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3109;
		public virtual void set(android.graphics.ColorMatrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._set3109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set3109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set3110;
		public virtual void set(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._set3110, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set3110, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset3111;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._reset3111);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._reset3111);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScale3112;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setScale3112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setScale3112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRotate3113;
		public virtual void setRotate(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setRotate3113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRotate3113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setConcat3114;
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setConcat3114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setConcat3114, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _preConcat3115;
		public virtual void preConcat(android.graphics.ColorMatrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._preConcat3115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._preConcat3115, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _postConcat3116;
		public virtual void postConcat(android.graphics.ColorMatrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._postConcat3116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._postConcat3116, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSaturation3117;
		public virtual void setSaturation(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setSaturation3117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setSaturation3117, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRGB2YUV3118;
		public virtual void setRGB2YUV() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setRGB2YUV3118);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRGB2YUV3118);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setYUV2RGB3119;
		public virtual void setYUV2RGB() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setYUV2RGB3119);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setYUV2RGB3119);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix3120;
		public ColorMatrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3120, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix3121;
		public ColorMatrix(float[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3121, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix3122;
		public ColorMatrix(android.graphics.ColorMatrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3122, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.ColorMatrix.staticClass = @__class;
			global::android.graphics.ColorMatrix._getArray3108 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F");
			global::android.graphics.ColorMatrix._set3109 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._set3110 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V");
			global::android.graphics.ColorMatrix._reset3111 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "reset", "()V");
			global::android.graphics.ColorMatrix._setScale3112 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.ColorMatrix._setRotate3113 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V");
			global::android.graphics.ColorMatrix._setConcat3114 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._preConcat3115 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._postConcat3116 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._setSaturation3117 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V");
			global::android.graphics.ColorMatrix._setRGB2YUV3118 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V");
			global::android.graphics.ColorMatrix._setYUV2RGB3119 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix3120 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix3121 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V");
			global::android.graphics.ColorMatrix._ColorMatrix3122 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
		}
	}
}
