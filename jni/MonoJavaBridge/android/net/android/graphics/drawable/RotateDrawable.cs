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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3738; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _inflate3738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _inflate3738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3739; 
		public virtual android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable3739)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _getDrawable3739)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3740; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _draw3740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _draw3740, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3741; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3741); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getChangingConfigurations3741); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3742; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setAlpha3742, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3743; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setColorFilter3743, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3744; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3744); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _isStateful3744); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3745; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _setVisible3745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3746; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3746); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getOpacity3746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3747; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3747, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onStateChange3747, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3748; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onLevelChange3748, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3749; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _onBoundsChange3749, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3750; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3750); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getIntrinsicWidth3750); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3751; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3751); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getIntrinsicHeight3751); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3752; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _getPadding3752, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3753; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3753)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _mutate3753)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3754; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3754)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.RotateDrawable.staticClass, _getConstantState3754)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3755; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _invalidateDrawable3755, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3756; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _scheduleDrawable3756, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3757; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.RotateDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.RotateDrawable.staticClass, _unscheduleDrawable3757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RotateDrawable3758; 
		public RotateDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.RotateDrawable.staticClass, _RotateDrawable3758, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.RotateDrawable.staticClass = @__class; 
			global::android.graphics.drawable.RotateDrawable._inflate3738 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.RotateDrawable._getDrawable3739 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.RotateDrawable._draw3740 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.RotateDrawable._getChangingConfigurations3741 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.RotateDrawable._setAlpha3742 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.RotateDrawable._setColorFilter3743 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.RotateDrawable._isStateful3744 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.RotateDrawable._setVisible3745 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.RotateDrawable._getOpacity3746 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.RotateDrawable._onStateChange3747 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.RotateDrawable._onLevelChange3748 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.RotateDrawable._onBoundsChange3749 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth3750 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight3751 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.RotateDrawable._getPadding3752 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.RotateDrawable._mutate3753 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.RotateDrawable._getConstantState3754 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.RotateDrawable._invalidateDrawable3755 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.RotateDrawable._scheduleDrawable3756 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.RotateDrawable._unscheduleDrawable3757 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.RotateDrawable._RotateDrawable3758 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
