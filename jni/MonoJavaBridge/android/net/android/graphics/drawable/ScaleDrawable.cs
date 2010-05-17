namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ScaleDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ScaleDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.ScaleDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.ScaleDrawable(@__env); 
			} 
		} 
		protected ScaleDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3553; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _inflate3553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _inflate3553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3554; 
		public virtual android.graphics.drawable.Drawable getDrawable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable3554)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ScaleDrawable.staticClass, _getDrawable3554)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3555; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _draw3555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _draw3555, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3556; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3556); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _getChangingConfigurations3556); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3557; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _setAlpha3557, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3558; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _setColorFilter3558, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3559; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3559); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _isStateful3559); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3560; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _setVisible3560, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3561; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3561); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _getOpacity3561); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3562; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3562, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _onStateChange3562, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3563; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _onLevelChange3563, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3564; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _onBoundsChange3564, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3565; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3565); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _getIntrinsicWidth3565); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3566; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3566); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _getIntrinsicHeight3566); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3567; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _getPadding3567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3568; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3568)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ScaleDrawable.staticClass, _mutate3568)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3569; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3569)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ScaleDrawable.staticClass, _getConstantState3569)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3570; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _invalidateDrawable3570, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3571; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _scheduleDrawable3571, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3572; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ScaleDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ScaleDrawable.staticClass, _unscheduleDrawable3572, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ScaleDrawable3573; 
		public ScaleDrawable(android.graphics.drawable.Drawable arg0, int arg1, float arg2, float arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ScaleDrawable.staticClass, _ScaleDrawable3573, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.ScaleDrawable.staticClass = @__class; 
			global::android.graphics.drawable.ScaleDrawable._inflate3553 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.ScaleDrawable._getDrawable3554 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.ScaleDrawable._draw3555 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.ScaleDrawable._getChangingConfigurations3556 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.ScaleDrawable._setAlpha3557 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.ScaleDrawable._setColorFilter3558 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.ScaleDrawable._isStateful3559 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.ScaleDrawable._setVisible3560 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.ScaleDrawable._getOpacity3561 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.ScaleDrawable._onStateChange3562 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.ScaleDrawable._onLevelChange3563 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.ScaleDrawable._onBoundsChange3564 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicWidth3565 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.ScaleDrawable._getIntrinsicHeight3566 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.ScaleDrawable._getPadding3567 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.ScaleDrawable._mutate3568 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.ScaleDrawable._getConstantState3569 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.ScaleDrawable._invalidateDrawable3570 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.ScaleDrawable._scheduleDrawable3571 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.ScaleDrawable._unscheduleDrawable3572 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.ScaleDrawable._ScaleDrawable3573 = @__env.GetMethodID(global::android.graphics.drawable.ScaleDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;IFF)V"); 
		} 
	} 
} 
