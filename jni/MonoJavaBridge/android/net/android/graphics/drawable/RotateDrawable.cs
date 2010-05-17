namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RotateDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RotateDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.RotateDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.RotateDrawable(@__env); 
			} 
		} 
		protected RotateDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3532; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _inflate3532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _inflate3532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3533; 
		public virtual android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable3533)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _getDrawable3533)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3534; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _draw3534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _draw3534, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3535; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3535); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getChangingConfigurations3535); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3536; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setAlpha3536, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3537; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setColorFilter3537, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3538; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3538); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _isStateful3538); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3539; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setVisible3539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3540; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3540); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getOpacity3540); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3541; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3541, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onStateChange3541, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3542; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onLevelChange3542, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3543; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onBoundsChange3543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3544; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3544); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getIntrinsicWidth3544); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3545; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3545); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getIntrinsicHeight3545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3546; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getPadding3546, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3547; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3547)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _mutate3547)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3548; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3548)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _getConstantState3548)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3549; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _invalidateDrawable3549, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3550; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _scheduleDrawable3550, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3551; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _unscheduleDrawable3551, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RotateDrawable3552; 
		public RotateDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.RotateDrawable.staticClass, _RotateDrawable3552, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.RotateDrawable.staticClass = @__class; 
			global::android.graphics.drawable.RotateDrawable._inflate3532 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.RotateDrawable._getDrawable3533 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.RotateDrawable._draw3534 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.RotateDrawable._getChangingConfigurations3535 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.RotateDrawable._setAlpha3536 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.RotateDrawable._setColorFilter3537 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.RotateDrawable._isStateful3538 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.RotateDrawable._setVisible3539 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.RotateDrawable._getOpacity3540 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.RotateDrawable._onStateChange3541 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.RotateDrawable._onLevelChange3542 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.RotateDrawable._onBoundsChange3543 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth3544 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight3545 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.RotateDrawable._getPadding3546 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.RotateDrawable._mutate3547 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.RotateDrawable._getConstantState3548 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.RotateDrawable._invalidateDrawable3549 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.RotateDrawable._scheduleDrawable3550 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.RotateDrawable._unscheduleDrawable3551 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.RotateDrawable._RotateDrawable3552 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
