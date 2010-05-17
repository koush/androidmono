namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NinePatchDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static NinePatchDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.NinePatchDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.NinePatchDrawable(@__env); 
			} 
		} 
		protected NinePatchDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3492; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _inflate3492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _inflate3492, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3493; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _draw3493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _draw3493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3494; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3494); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getChangingConfigurations3494); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3495; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setDither3495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setDither3495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3496; 
		public override void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setFilterBitmap3496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setFilterBitmap3496, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3497; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setAlpha3497, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3498; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setColorFilter3498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3499; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3499); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getOpacity3499); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3500; 
		public override android.graphics.Region getTransparentRegion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, _getTransparentRegion3500)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getTransparentRegion3500)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3501; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3501); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getIntrinsicWidth3501); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3502; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3502); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getIntrinsicHeight3502); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3503; 
		public override int getMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getMinimumWidth3503); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getMinimumWidth3503); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3504; 
		public override int getMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallIntMethod(this, _getMinimumHeight3504); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getMinimumHeight3504); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3505; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getPadding3505, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3506; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3506)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.NinePatchDrawable.staticClass, _mutate3506)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3507; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3507)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getConstantState3507)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3508; 
		public virtual android.graphics.Paint getPaint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, _getPaint3508)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.NinePatchDrawable.staticClass, _getPaint3508)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3509; 
		public virtual void setTargetDensity(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setTargetDensity3509, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3510; 
		public virtual void setTargetDensity(android.util.DisplayMetrics arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setTargetDensity3510, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTargetDensity3511; 
		public virtual void setTargetDensity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.NinePatchDrawable)) 
				@__env.CallVoidMethod(this, _setTargetDensity3511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.NinePatchDrawable.staticClass, _setTargetDensity3511, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3512; 
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.NinePatch arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, _NinePatchDrawable3512, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3513; 
		public NinePatchDrawable(android.content.res.Resources arg0, android.graphics.Bitmap arg1, byte[] arg2, android.graphics.Rect arg3, java.lang.String arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, _NinePatchDrawable3513, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3514; 
		public NinePatchDrawable(android.graphics.NinePatch arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, _NinePatchDrawable3514, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NinePatchDrawable3515; 
		public NinePatchDrawable(android.graphics.Bitmap arg0, byte[] arg1, android.graphics.Rect arg2, java.lang.String arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.NinePatchDrawable.staticClass, _NinePatchDrawable3515, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.NinePatchDrawable.staticClass = @__class; 
			global::android.graphics.drawable.NinePatchDrawable._inflate3492 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._draw3493 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._getChangingConfigurations3494 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._setDither3495 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.NinePatchDrawable._setFilterBitmap3496 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.drawable.NinePatchDrawable._setAlpha3497 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.NinePatchDrawable._setColorFilter3498 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._getOpacity3499 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._getTransparentRegion3500 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;"); 
			global::android.graphics.drawable.NinePatchDrawable._getIntrinsicWidth3501 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._getIntrinsicHeight3502 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._getMinimumWidth3503 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumWidth", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._getMinimumHeight3504 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getMinimumHeight", "()I"); 
			global::android.graphics.drawable.NinePatchDrawable._getPadding3505 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.NinePatchDrawable._mutate3506 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.NinePatchDrawable._getConstantState3507 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.NinePatchDrawable._getPaint3508 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;"); 
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3509 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3510 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(Landroid/util/DisplayMetrics;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._setTargetDensity3511 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "setTargetDensity", "(I)V"); 
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3512 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/NinePatch;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3513 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/content/res/Resources;Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3514 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/NinePatch;)V"); 
			global::android.graphics.drawable.NinePatchDrawable._NinePatchDrawable3515 = @__env.GetMethodID(global::android.graphics.drawable.NinePatchDrawable.staticClass, "<init>", "(Landroid/graphics/Bitmap;[BLandroid/graphics/Rect;Ljava/lang/String;)V"); 
		} 
	} 
} 
