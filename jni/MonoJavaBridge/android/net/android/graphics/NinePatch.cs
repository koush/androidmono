namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NinePatch : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static NinePatch() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.NinePatch), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _draw2824; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.RectF arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, _draw2824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.NinePatch.staticClass, _draw2824, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2825; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, _draw2825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.NinePatch.staticClass, _draw2825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw2826; 
		public virtual void draw(android.graphics.Canvas arg0, android.graphics.Rect arg1, android.graphics.Paint arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, _draw2826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.NinePatch.staticClass, _draw2826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion2827; 
		public virtual android.graphics.Region getTransparentRegion(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, _getTransparentRegion2827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.NinePatch.staticClass, _getTransparentRegion2827, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDensity2828; 
		public virtual int getDensity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, _getDensity2828); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.NinePatch.staticClass, _getDensity2828); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWidth2829; 
		public virtual int getWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, _getWidth2829); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.NinePatch.staticClass, _getWidth2829); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight2830; 
		public virtual int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallIntMethod(this, _getHeight2830); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.NinePatch.staticClass, _getHeight2830); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasAlpha2831; 
		public virtual bool hasAlpha() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				return @__env.CallBooleanMethod(this, _hasAlpha2831); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.NinePatch.staticClass, _hasAlpha2831); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPaint2832; 
		public virtual void setPaint(android.graphics.Paint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.NinePatch)) 
				@__env.CallVoidMethod(this, _setPaint2832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.NinePatch.staticClass, _setPaint2832, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNinePatchChunk2833; 
		public static bool isNinePatchChunk(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.graphics.NinePatch.staticClass, _isNinePatchChunk2833, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatch2834; 
		public NinePatch(android.graphics.Bitmap arg0, byte[] arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.NinePatch.staticClass, _NinePatch2834, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.NinePatch.staticClass = @__class; 
			global::android.graphics.NinePatch._draw2824 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;)V"); 
			global::android.graphics.NinePatch._draw2825 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;)V"); 
			global::android.graphics.NinePatch._draw2826 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Rect;Landroid/graphics/Paint;)V"); 
			global::android.graphics.NinePatch._getTransparentRegion2827 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getTransparentRegion", "(Landroid/graphics/Rect;)Landroid/graphics/Region;"); 
			global::android.graphics.NinePatch._getDensity2828 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getDensity", "()I"); 
			global::android.graphics.NinePatch._getWidth2829 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getWidth", "()I"); 
			global::android.graphics.NinePatch._getHeight2830 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "getHeight", "()I"); 
			global::android.graphics.NinePatch._hasAlpha2831 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "hasAlpha", "()Z"); 
			global::android.graphics.NinePatch._setPaint2832 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "setPaint", "(Landroid/graphics/Paint;)V"); 
			global::android.graphics.NinePatch._isNinePatchChunk2833 = @__env.GetStaticMethodID(global::android.graphics.NinePatch.staticClass, "isNinePatchChunk", "([B)Z"); 
			global::android.graphics.NinePatch._NinePatch2834 = @__env.GetMethodID(global::android.graphics.NinePatch.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLjava/lang/String;)V"); 
		} 
	} 
} 
