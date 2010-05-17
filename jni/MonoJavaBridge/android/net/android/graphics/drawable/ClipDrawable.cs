namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ClipDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ClipDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.ClipDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.ClipDrawable(@__env); 
			} 
		} 
		protected ClipDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3281; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _inflate3281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _inflate3281, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3282; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _draw3282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _draw3282, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3283; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3283); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _getChangingConfigurations3283); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3284; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _setAlpha3284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3285; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _setColorFilter3285, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3286; 
		public override bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3286); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _isStateful3286); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3287; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _setVisible3287, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3288; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3288); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _getOpacity3288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3289; 
		protected override bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3289, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _onStateChange3289, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3290; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _onLevelChange3290, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3291; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _onBoundsChange3291, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3292; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3292); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _getIntrinsicWidth3292); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3293; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3293); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _getIntrinsicHeight3293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3294; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _getPadding3294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3295; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3295)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.ClipDrawable.staticClass, _getConstantState3295)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3296; 
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _invalidateDrawable3296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _invalidateDrawable3296, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3297; 
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _scheduleDrawable3297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _scheduleDrawable3297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3298; 
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.ClipDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleDrawable3298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.ClipDrawable.staticClass, _unscheduleDrawable3298, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ClipDrawable3299; 
		public ClipDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.ClipDrawable.staticClass, _ClipDrawable3299, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		public static int HORIZONTAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int VERTICAL
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.ClipDrawable.staticClass = @__class; 
			global::android.graphics.drawable.ClipDrawable._inflate3281 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.ClipDrawable._draw3282 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3283 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.ClipDrawable._setAlpha3284 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.ClipDrawable._setColorFilter3285 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.ClipDrawable._isStateful3286 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.ClipDrawable._setVisible3287 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.ClipDrawable._getOpacity3288 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.ClipDrawable._onStateChange3289 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.ClipDrawable._onLevelChange3290 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.ClipDrawable._onBoundsChange3291 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3292 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3293 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.ClipDrawable._getPadding3294 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.ClipDrawable._getConstantState3295 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.ClipDrawable._invalidateDrawable3296 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.graphics.drawable.ClipDrawable._scheduleDrawable3297 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3298 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.ClipDrawable._ClipDrawable3299 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;II)V"); 
		} 
	} 
} 
