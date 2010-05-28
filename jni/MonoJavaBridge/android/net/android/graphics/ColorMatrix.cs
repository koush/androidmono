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
		internal static global::net.sf.jni4net.jni.MethodId _getArray2911; 
		public virtual float[] getArray() 
		{ 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.ColorMatrix._getArray2911)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._getArray2911)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2912; 
		public virtual void set(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._set2912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set2912, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2913; 
		public virtual void set(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._set2913, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set2913, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2914; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._reset2914); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._reset2914); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2915; 
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setScale2915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setScale2915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2916; 
		public virtual void setRotate(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setRotate2916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRotate2916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConcat2917; 
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setConcat2917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setConcat2917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preConcat2918; 
		public virtual void preConcat(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._preConcat2918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._preConcat2918, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postConcat2919; 
		public virtual void postConcat(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._postConcat2919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._postConcat2919, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSaturation2920; 
		public virtual void setSaturation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setSaturation2920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setSaturation2920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRGB2YUV2921; 
		public virtual void setRGB2YUV() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setRGB2YUV2921); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRGB2YUV2921); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setYUV2RGB2922; 
		public virtual void setYUV2RGB() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, global::android.graphics.ColorMatrix._setYUV2RGB2922); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setYUV2RGB2922); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2923; 
		public ColorMatrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix2923, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2924; 
		public ColorMatrix(float[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix2924, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2925; 
		public ColorMatrix(android.graphics.ColorMatrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix2925, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.ColorMatrix.staticClass = @__class; 
			global::android.graphics.ColorMatrix._getArray2911 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F"); 
			global::android.graphics.ColorMatrix._set2912 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._set2913 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V"); 
			global::android.graphics.ColorMatrix._reset2914 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "reset", "()V"); 
			global::android.graphics.ColorMatrix._setScale2915 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V"); 
			global::android.graphics.ColorMatrix._setRotate2916 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V"); 
			global::android.graphics.ColorMatrix._setConcat2917 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._preConcat2918 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._postConcat2919 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._setSaturation2920 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V"); 
			global::android.graphics.ColorMatrix._setRGB2YUV2921 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V"); 
			global::android.graphics.ColorMatrix._setYUV2RGB2922 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2923 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2924 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2925 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V"); 
		} 
	} 
} 
