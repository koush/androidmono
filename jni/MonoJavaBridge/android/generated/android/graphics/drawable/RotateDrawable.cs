namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RotateDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static RotateDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.RotateDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3944;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._inflate3944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._inflate3944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable3945;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable._getDrawable3945));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getDrawable3945));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3946;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._draw3946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._draw3946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3947;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations3947);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getChangingConfigurations3947);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3948;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._setAlpha3948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setAlpha3948, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3949;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._setColorFilter3949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setColorFilter3949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3950;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.RotateDrawable._isStateful3950);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._isStateful3950);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3951;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.RotateDrawable._setVisible3951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._setVisible3951, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3952;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.RotateDrawable._getOpacity3952);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getOpacity3952);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3953;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.RotateDrawable._onStateChange3953, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onStateChange3953, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3954;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.RotateDrawable._onLevelChange3954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onLevelChange3954, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3955;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._onBoundsChange3955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._onBoundsChange3955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3956;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth3956);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth3956);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3957;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight3957);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight3957);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3958;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.RotateDrawable._getPadding3958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getPadding3958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3959;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable._mutate3959));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._mutate3959));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3960;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable._getConstantState3960));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._getConstantState3960));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3961;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._invalidateDrawable3961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._invalidateDrawable3961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3962;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._scheduleDrawable3962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._scheduleDrawable3962, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3963;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable3963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._unscheduleDrawable3963, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RotateDrawable3964;
		public RotateDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.RotateDrawable.staticClass, global::android.graphics.drawable.RotateDrawable._RotateDrawable3964, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.RotateDrawable.staticClass = @__class;
			global::android.graphics.drawable.RotateDrawable._inflate3944 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.RotateDrawable._getDrawable3945 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._draw3946 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.RotateDrawable._getChangingConfigurations3947 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.RotateDrawable._setAlpha3948 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.RotateDrawable._setColorFilter3949 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.RotateDrawable._isStateful3950 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.RotateDrawable._setVisible3951 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.RotateDrawable._getOpacity3952 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.RotateDrawable._onStateChange3953 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.RotateDrawable._onLevelChange3954 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.RotateDrawable._onBoundsChange3955 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicWidth3956 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.RotateDrawable._getIntrinsicHeight3957 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.RotateDrawable._getPadding3958 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.RotateDrawable._mutate3959 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.RotateDrawable._getConstantState3960 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.RotateDrawable._invalidateDrawable3961 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.RotateDrawable._scheduleDrawable3962 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.RotateDrawable._unscheduleDrawable3963 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.RotateDrawable._RotateDrawable3964 = @__env.GetMethodID(global::android.graphics.drawable.RotateDrawable.staticClass, "<init>", "()V");
		}
	}
}
