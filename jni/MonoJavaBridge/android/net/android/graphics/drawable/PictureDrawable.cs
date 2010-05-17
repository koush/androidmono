namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PictureDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PictureDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.PictureDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.PictureDrawable(@__env); 
			} 
		} 
		protected PictureDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3521; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _draw3521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _draw3521, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3522; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _setDither3522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _setDither3522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3523; 
		public override void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _setFilterBitmap3523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _setFilterBitmap3523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3524; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _setAlpha3524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3525; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _setColorFilter3525, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3526; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3526); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _getOpacity3526); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3527; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3527); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _getIntrinsicWidth3527); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3528; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3528); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _getIntrinsicHeight3528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPicture3529; 
		public virtual android.graphics.Picture getPicture() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallObjectMethodPtr(this, _getPicture3529)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Picture>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.PictureDrawable.staticClass, _getPicture3529)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPicture3530; 
		public virtual void setPicture(android.graphics.Picture arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.PictureDrawable)) 
				@__env.CallVoidMethod(this, _setPicture3530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.PictureDrawable.staticClass, _setPicture3530, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PictureDrawable3531; 
		public PictureDrawable(android.graphics.Picture arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.PictureDrawable.staticClass, _PictureDrawable3531, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.PictureDrawable.staticClass = @__class; 
			global::android.graphics.drawable.PictureDrawable._draw3521 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.PictureDrawable._setDither3522 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.PictureDrawable._setFilterBitmap3523 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.drawable.PictureDrawable._setAlpha3524 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.PictureDrawable._setColorFilter3525 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.PictureDrawable._getOpacity3526 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.PictureDrawable._getIntrinsicWidth3527 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.PictureDrawable._getIntrinsicHeight3528 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.PictureDrawable._getPicture3529 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "getPicture", "()Landroid/graphics/Picture;"); 
			global::android.graphics.drawable.PictureDrawable._setPicture3530 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "setPicture", "(Landroid/graphics/Picture;)V"); 
			global::android.graphics.drawable.PictureDrawable._PictureDrawable3531 = @__env.GetMethodID(global::android.graphics.drawable.PictureDrawable.staticClass, "<init>", "(Landroid/graphics/Picture;)V"); 
		} 
	} 
} 
