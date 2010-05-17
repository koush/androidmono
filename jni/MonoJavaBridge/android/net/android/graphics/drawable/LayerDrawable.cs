namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LayerDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LayerDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.LayerDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.LayerDrawable(@__env); 
			} 
		} 
		protected LayerDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getId3459; 
		public virtual int getId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getId3459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getId3459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3460; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _inflate3460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _inflate3460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3461; 
		public virtual android.graphics.drawable.Drawable getDrawable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getDrawable3461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.LayerDrawable.staticClass, _getDrawable3461, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3462; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _draw3462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _draw3462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3463; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3463); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getChangingConfigurations3463); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3464; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _setDither3464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setDither3464, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3465; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setAlpha3465, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3466; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setColorFilter3466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3467; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3467); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _isStateful3467); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3468; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setVisible3468, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3469; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3469); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getOpacity3469); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3470; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3470, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _onStateChange3470, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3471; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _onLevelChange3471, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3472; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _onBoundsChange3472, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3473; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3473); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getIntrinsicWidth3473); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3474; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3474); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getIntrinsicHeight3474); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3475; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getPadding3475, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3476; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3476)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.LayerDrawable.staticClass, _mutate3476)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3477; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3477)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.LayerDrawable.staticClass, _getConstantState3477)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3478; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _invalidateDrawable3478, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3479; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _scheduleDrawable3479, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3480; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _unscheduleDrawable3480, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setId3481; 
		public virtual void setId(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _setId3481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setId3481, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _findDrawableByLayerId3482; 
		public virtual android.graphics.drawable.Drawable findDrawableByLayerId(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _findDrawableByLayerId3482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.LayerDrawable.staticClass, _findDrawableByLayerId3482, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfLayers3483; 
		public virtual int getNumberOfLayers() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallIntMethod(this, _getNumberOfLayers3483); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _getNumberOfLayers3483); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDrawableByLayerId3484; 
		public virtual bool setDrawableByLayerId(int arg0, android.graphics.drawable.Drawable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				return @__env.CallBooleanMethod(this, _setDrawableByLayerId3484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setDrawableByLayerId3484, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayerInset3485; 
		public virtual void setLayerInset(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.LayerDrawable)) 
				@__env.CallVoidMethod(this, _setLayerInset3485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.LayerDrawable.staticClass, _setLayerInset3485, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LayerDrawable3486; 
		public LayerDrawable(android.graphics.drawable.Drawable[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.LayerDrawable.staticClass, _LayerDrawable3486, this, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.LayerDrawable.staticClass = @__class; 
			global::android.graphics.drawable.LayerDrawable._getId3459 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getId", "(I)I"); 
			global::android.graphics.drawable.LayerDrawable._inflate3460 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.LayerDrawable._getDrawable3461 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.LayerDrawable._draw3462 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.LayerDrawable._getChangingConfigurations3463 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.LayerDrawable._setDither3464 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.LayerDrawable._setAlpha3465 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.LayerDrawable._setColorFilter3466 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.LayerDrawable._isStateful3467 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.LayerDrawable._setVisible3468 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.LayerDrawable._getOpacity3469 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.LayerDrawable._onStateChange3470 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.LayerDrawable._onLevelChange3471 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.LayerDrawable._onBoundsChange3472 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.LayerDrawable._getIntrinsicWidth3473 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.LayerDrawable._getIntrinsicHeight3474 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.LayerDrawable._getPadding3475 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.LayerDrawable._mutate3476 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.LayerDrawable._getConstantState3477 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.LayerDrawable._invalidateDrawable3478 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.LayerDrawable._scheduleDrawable3479 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.LayerDrawable._unscheduleDrawable3480 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.LayerDrawable._setId3481 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setId", "(II)V"); 
			global::android.graphics.drawable.LayerDrawable._findDrawableByLayerId3482 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "findDrawableByLayerId", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.LayerDrawable._getNumberOfLayers3483 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "getNumberOfLayers", "()I"); 
			global::android.graphics.drawable.LayerDrawable._setDrawableByLayerId3484 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setDrawableByLayerId", "(ILandroid/graphics/drawable/Drawable;)Z"); 
			global::android.graphics.drawable.LayerDrawable._setLayerInset3485 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "setLayerInset", "(IIIII)V"); 
			global::android.graphics.drawable.LayerDrawable._LayerDrawable3486 = @__env.GetMethodID(global::android.graphics.drawable.LayerDrawable.staticClass, "<init>", "([Landroid/graphics/drawable/Drawable;)V"); 
		} 
	} 
} 
