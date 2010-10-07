namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class NinePatch : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static NinePatch()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.NinePatch), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.NinePatch(@__env);
			}
		}
		protected NinePatch(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3223;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3223, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3224;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3225;
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3226;
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.NinePatch._getTransparentRegion3226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getTransparentRegion3226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDensity3227;
		public virtual int getDensity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getDensity3227);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getDensity3227);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3228;
		public virtual int getWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getWidth3228);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getWidth3228);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3229;
		public virtual int getHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getHeight3229);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getHeight3229);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha3230;
		public virtual bool hasAlpha() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.NinePatch._hasAlpha3230);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._hasAlpha3230);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPaint3231;
		public virtual void setPaint(android.graphics.Paint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._setPaint3231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._setPaint3231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNinePatchChunk3232;
		public static bool isNinePatchChunk(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._isNinePatchChunk3232, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NinePatch3233;
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._NinePatch3233, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.NinePatch.staticClass = @__class;
			global::android.graphics.NinePatch._draw3223 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V");
			global::android.graphics.NinePatch._draw3224 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V");
			global::android.graphics.NinePatch._draw3225 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._getTransparentRegion3226 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;");
			global::android.graphics.NinePatch._getDensity3227 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getDensity", "()I");
			global::android.graphics.NinePatch._getWidth3228 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getWidth", "()I");
			global::android.graphics.NinePatch._getHeight3229 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getHeight", "()I");
			global::android.graphics.NinePatch._hasAlpha3230 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z");
			global::android.graphics.NinePatch._setPaint3231 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V");
			global::android.graphics.NinePatch._isNinePatchChunk3232 = @__env.GetStaticMethodID(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z");
			global::android.graphics.NinePatch._NinePatch3233 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V");
		}
	}
}
