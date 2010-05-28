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
		internal static global::net.sf.jni4net.jni.MethodId _draw3024; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3024, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3024, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3025; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3025, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3026; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._draw3026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._draw3026, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3027; 
		public virtual global::android.graphics.Region getTransparentRegion(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.NinePatch._getTransparentRegion3027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getTransparentRegion3027, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDensity3028; 
		public virtual int getDensity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getDensity3028); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getDensity3028); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth3029; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getWidth3029); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getWidth3029); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight3030; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, global::android.graphics.NinePatch._getHeight3030); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._getHeight3030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha3031; 
		public virtual bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.NinePatch._hasAlpha3031); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._hasAlpha3031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPaint3032; 
		public virtual void setPaint(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, global::android.graphics.NinePatch._setPaint3032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._setPaint3032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNinePatchChunk3033; 
		public static bool isNinePatchChunk(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._isNinePatchChunk3033, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatch3034; 
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.NinePatch.staticClass, global::android.graphics.NinePatch._NinePatch3034, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.NinePatch.staticClass = @__class; 
			global::android.graphics.NinePatch._draw3024 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V"); 
			global::android.graphics.NinePatch._draw3025 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V"); 
			global::android.graphics.NinePatch._draw3026 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V"); 
			global::android.graphics.NinePatch._getTransparentRegion3027 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;"); 
			global::android.graphics.NinePatch._getDensity3028 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getDensity", "()I"); 
			global::android.graphics.NinePatch._getWidth3029 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getWidth", "()I"); 
			global::android.graphics.NinePatch._getHeight3030 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getHeight", "()I"); 
			global::android.graphics.NinePatch._hasAlpha3031 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.NinePatch._setPaint3032 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.NinePatch._isNinePatchChunk3033 = @__env.GetStaticMethodID(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z"); 
			global::android.graphics.NinePatch._NinePatch3034 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V"); 
		} 
	} 
} 
