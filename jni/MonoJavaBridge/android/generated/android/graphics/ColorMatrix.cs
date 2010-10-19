namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorMatrix : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ColorMatrix()
		{
			InitJNI();
		}
		protected ColorMatrix(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new float[] Array
		{
			get
			{
				return getArray();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getArray3285;
		public virtual float[] getArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.ColorMatrix._getArray3285)) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._getArray3285)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _set3286;
		public virtual void set(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._set3286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set3286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set3287;
		public virtual void set(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._set3287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set3287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset3288;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._reset3288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._reset3288);
		}
		internal static global::MonoJavaBridge.MethodId _setScale3289;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setScale3289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setScale3289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate3290;
		public virtual void setRotate(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setRotate3290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRotate3290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConcat3291;
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setConcat3291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setConcat3291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preConcat3292;
		public virtual void preConcat(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._preConcat3292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._preConcat3292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postConcat3293;
		public virtual void postConcat(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._postConcat3293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._postConcat3293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSaturation3294;
		public virtual void setSaturation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setSaturation3294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setSaturation3294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRGB2YUV3295;
		public virtual void setRGB2YUV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setRGB2YUV3295);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRGB2YUV3295);
		}
		internal static global::MonoJavaBridge.MethodId _setYUV2RGB3296;
		public virtual void setYUV2RGB() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setYUV2RGB3296);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setYUV2RGB3296);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix3297;
		public ColorMatrix()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3297);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix3298;
		public ColorMatrix(float[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix3299;
		public ColorMatrix(android.graphics.ColorMatrix arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix3299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorMatrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorMatrix"));
			global::android.graphics.ColorMatrix._getArray3285 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F");
			global::android.graphics.ColorMatrix._set3286 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._set3287 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V");
			global::android.graphics.ColorMatrix._reset3288 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "reset", "()V");
			global::android.graphics.ColorMatrix._setScale3289 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.ColorMatrix._setRotate3290 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V");
			global::android.graphics.ColorMatrix._setConcat3291 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._preConcat3292 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._postConcat3293 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._setSaturation3294 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V");
			global::android.graphics.ColorMatrix._setRGB2YUV3295 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V");
			global::android.graphics.ColorMatrix._setYUV2RGB3296 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix3297 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix3298 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V");
			global::android.graphics.ColorMatrix._ColorMatrix3299 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
		}
	}
}
