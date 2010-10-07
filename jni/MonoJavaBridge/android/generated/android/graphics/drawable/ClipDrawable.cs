namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ClipDrawable : android.graphics.drawable.Drawable, android.graphics.drawable.Drawable.Callback
	{
		internal new static global::java.lang.Class staticClass;
		static ClipDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.ClipDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
		internal static global::net.sf.jni4net.jni.MethodId _inflate3690;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._inflate3690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._inflate3690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3691;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._draw3691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._draw3691, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3692;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3692);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3692);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3693;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._setAlpha3693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setAlpha3693, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3694;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._setColorFilter3694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setColorFilter3694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3695;
		public override bool isStateful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ClipDrawable._isStateful3695);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._isStateful3695);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3696;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ClipDrawable._setVisible3696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._setVisible3696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3697;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ClipDrawable._getOpacity3697);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getOpacity3697);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3698;
		protected override bool onStateChange(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ClipDrawable._onStateChange3698, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onStateChange3698, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3699;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ClipDrawable._onLevelChange3699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onLevelChange3699, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3700;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._onBoundsChange3700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._onBoundsChange3700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3701;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3701);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3701);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3702;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3702);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3702);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3703;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ClipDrawable._getPadding3703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getPadding3703, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3704;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ClipDrawable._getConstantState3704));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._getConstantState3704));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable3705;
		public virtual void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._invalidateDrawable3705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._invalidateDrawable3705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _scheduleDrawable3706;
		public virtual void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._scheduleDrawable3706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._scheduleDrawable3706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleDrawable3707;
		public virtual void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ClipDrawable3708;
		public ClipDrawable(android.graphics.drawable.Drawable arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.ClipDrawable.staticClass, global::android.graphics.drawable.ClipDrawable._ClipDrawable3708, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
			global::android.graphics.drawable.ClipDrawable._inflate3690 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ClipDrawable._draw3691 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ClipDrawable._getChangingConfigurations3692 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ClipDrawable._setAlpha3693 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ClipDrawable._setColorFilter3694 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ClipDrawable._isStateful3695 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.ClipDrawable._setVisible3696 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.ClipDrawable._getOpacity3697 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ClipDrawable._onStateChange3698 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.ClipDrawable._onLevelChange3699 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.ClipDrawable._onBoundsChange3700 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicWidth3701 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ClipDrawable._getIntrinsicHeight3702 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ClipDrawable._getPadding3703 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ClipDrawable._getConstantState3704 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ClipDrawable._invalidateDrawable3705 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.ClipDrawable._scheduleDrawable3706 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
			global::android.graphics.drawable.ClipDrawable._unscheduleDrawable3707 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.ClipDrawable._ClipDrawable3708 = @__env.GetMethodID(global::android.graphics.drawable.ClipDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;II)V");
		}
	}
}
