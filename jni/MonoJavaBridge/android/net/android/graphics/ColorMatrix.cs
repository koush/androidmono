namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ColorMatrix : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static ColorMatrix() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.ColorMatrix), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getArray2711; 
		public virtual float[] getArray() 
		{ 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getArray2711)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.ColorMatrix.staticClass, _getArray2711)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2712; 
		public virtual void set(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _set2712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _set2712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _set2713; 
		public virtual void set(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _set2713, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _set2713, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset2714; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _reset2714); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _reset2714); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScale2715; 
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setScale2715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setScale2715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRotate2716; 
		public virtual void setRotate(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setRotate2716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setRotate2716, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setConcat2717; 
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setConcat2717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setConcat2717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _preConcat2718; 
		public virtual void preConcat(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _preConcat2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _preConcat2718, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _postConcat2719; 
		public virtual void postConcat(android.graphics.ColorMatrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _postConcat2719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _postConcat2719, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSaturation2720; 
		public virtual void setSaturation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setSaturation2720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setSaturation2720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRGB2YUV2721; 
		public virtual void setRGB2YUV() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setRGB2YUV2721); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setRGB2YUV2721); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setYUV2RGB2722; 
		public virtual void setYUV2RGB() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.ColorMatrix)) 
				@__env.CallVoidMethod(this, _setYUV2RGB2722); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.ColorMatrix.staticClass, _setYUV2RGB2722); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2723; 
		public ColorMatrix()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, _ColorMatrix2723, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2724; 
		public ColorMatrix(float[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, _ColorMatrix2724, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ColorMatrix2725; 
		public ColorMatrix(android.graphics.ColorMatrix arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.ColorMatrix.staticClass, _ColorMatrix2725, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.ColorMatrix.staticClass = @__class; 
			global::android.graphics.ColorMatrix._getArray2711 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F"); 
			global::android.graphics.ColorMatrix._set2712 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._set2713 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V"); 
			global::android.graphics.ColorMatrix._reset2714 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "reset", "()V"); 
			global::android.graphics.ColorMatrix._setScale2715 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V"); 
			global::android.graphics.ColorMatrix._setRotate2716 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V"); 
			global::android.graphics.ColorMatrix._setConcat2717 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._preConcat2718 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._postConcat2719 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V"); 
			global::android.graphics.ColorMatrix._setSaturation2720 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V"); 
			global::android.graphics.ColorMatrix._setRGB2YUV2721 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V"); 
			global::android.graphics.ColorMatrix._setYUV2RGB2722 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2723 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2724 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V"); 
			global::android.graphics.ColorMatrix._ColorMatrix2725 = @__env.GetMethodID(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V"); 
		} 
	} 
} 
