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
		internal static global::MonoJavaBridge.MethodId _getArray5222;
		public virtual float[] getArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.ColorMatrix._getArray5222)) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._getArray5222)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _set5223;
		public virtual void set(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._set5223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set5223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _set5224;
		public virtual void set(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._set5224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._set5224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset5225;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._reset5225);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._reset5225);
		}
		internal static global::MonoJavaBridge.MethodId _setScale5226;
		public virtual void setScale(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setScale5226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setScale5226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setRotate5227;
		public virtual void setRotate(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setRotate5227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRotate5227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setConcat5228;
		public virtual void setConcat(android.graphics.ColorMatrix arg0, android.graphics.ColorMatrix arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setConcat5228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setConcat5228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _preConcat5229;
		public virtual void preConcat(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._preConcat5229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._preConcat5229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _postConcat5230;
		public virtual void postConcat(android.graphics.ColorMatrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._postConcat5230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._postConcat5230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSaturation5231;
		public virtual void setSaturation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setSaturation5231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setSaturation5231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRGB2YUV5232;
		public virtual void setRGB2YUV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setRGB2YUV5232);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setRGB2YUV5232);
		}
		internal static global::MonoJavaBridge.MethodId _setYUV2RGB5233;
		public virtual void setYUV2RGB() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix._setYUV2RGB5233);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._setYUV2RGB5233);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5234;
		public ColorMatrix()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5234);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5235;
		public ColorMatrix(float[] arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorMatrix5236;
		public ColorMatrix(android.graphics.ColorMatrix arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.ColorMatrix.staticClass, global::android.graphics.ColorMatrix._ColorMatrix5236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.ColorMatrix.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/ColorMatrix"));
			global::android.graphics.ColorMatrix._getArray5222 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "getArray", "()[F");
			global::android.graphics.ColorMatrix._set5223 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._set5224 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "set", "([F)V");
			global::android.graphics.ColorMatrix._reset5225 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "reset", "()V");
			global::android.graphics.ColorMatrix._setScale5226 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setScale", "(FFFF)V");
			global::android.graphics.ColorMatrix._setRotate5227 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRotate", "(IF)V");
			global::android.graphics.ColorMatrix._setConcat5228 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setConcat", "(Landroid/graphics/ColorMatrix;Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._preConcat5229 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "preConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._postConcat5230 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "postConcat", "(Landroid/graphics/ColorMatrix;)V");
			global::android.graphics.ColorMatrix._setSaturation5231 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setSaturation", "(F)V");
			global::android.graphics.ColorMatrix._setRGB2YUV5232 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setRGB2YUV", "()V");
			global::android.graphics.ColorMatrix._setYUV2RGB5233 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "setYUV2RGB", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix5234 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "()V");
			global::android.graphics.ColorMatrix._ColorMatrix5235 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "([F)V");
			global::android.graphics.ColorMatrix._ColorMatrix5236 = @__env.GetMethodIDNoThrow(global::android.graphics.ColorMatrix.staticClass, "<init>", "(Landroid/graphics/ColorMatrix;)V");
		}
	}
}
