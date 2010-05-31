namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ShapeDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::java.lang.Class staticClass;
		static ShapeDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.ShapeDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.ShapeDrawable(@__env);
			}
		}
		protected ShapeDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public abstract class ShaderFactory : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static ShaderFactory()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			protected ShaderFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _resize3780;
			public abstract global::android.graphics.Shader resize(int arg0, int arg1);
			internal static global::net.sf.jni4net.jni.MethodId _ShaderFactory3781;
			public ShaderFactory()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory3781, this);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass = @__class;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._resize3780 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "resize", "(II)Landroid/graphics/Shader;");
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory3781 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "<init>", "()V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3782;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._inflate3782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._inflate3782, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3783;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._draw3783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._draw3783, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3784;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations3784);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations3784);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3785;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setDither3785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setDither3785, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3786;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setAlpha3786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setAlpha3786, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3787;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setColorFilter3787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setColorFilter3787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3788;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable._getOpacity3788);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getOpacity3788);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3789;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._onBoundsChange3789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._onBoundsChange3789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3790;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth3790);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth3790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3791;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight3791);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight3791);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3792;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable._getPadding3792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getPadding3792, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3793;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable._mutate3793));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._mutate3793));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3794;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable._getConstantState3794));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getConstantState3794));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw3795;
		protected virtual void onDraw(android.graphics.drawable.shapes.Shape arg0, android.graphics.Canvas arg1, android.graphics.Paint arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._onDraw3795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._onDraw3795, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding3796;
		public virtual void setPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setPadding3796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setPadding3796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding3797;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setPadding3797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setPadding3797, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPaint3798;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable._getPaint3798));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Paint>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getPaint3798));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShape3799;
		public virtual void setShape(android.graphics.drawable.shapes.Shape arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setShape3799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setShape3799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflateTag3800;
		protected virtual bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable._inflateTag3800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._inflateTag3800, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShape3801;
		public virtual global::android.graphics.drawable.shapes.Shape getShape() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable._getShape3801));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.shapes.Shape>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getShape3801));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShaderFactory3802;
		public virtual void setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setShaderFactory3802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setShaderFactory3802, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShaderFactory3803;
		public virtual global::android.graphics.drawable.ShapeDrawable.ShaderFactory getShaderFactory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.ShapeDrawable.ShaderFactory>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable._getShaderFactory3803));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.ShapeDrawable.ShaderFactory>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getShaderFactory3803));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntrinsicWidth3804;
		public virtual void setIntrinsicWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth3804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth3804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIntrinsicHeight3805;
		public virtual void setIntrinsicHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight3805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight3805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ShapeDrawable3806;
		public ShapeDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3806, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ShapeDrawable3807;
		public ShapeDrawable(android.graphics.drawable.shapes.Shape arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3807, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.ShapeDrawable.staticClass = @__class;
			global::android.graphics.drawable.ShapeDrawable._inflate3782 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ShapeDrawable._draw3783 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations3784 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ShapeDrawable._setDither3785 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.ShapeDrawable._setAlpha3786 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._setColorFilter3787 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ShapeDrawable._getOpacity3788 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ShapeDrawable._onBoundsChange3789 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth3790 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight3791 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ShapeDrawable._getPadding3792 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ShapeDrawable._mutate3793 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ShapeDrawable._getConstantState3794 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ShapeDrawable._onDraw3795 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.ShapeDrawable._setPadding3796 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ShapeDrawable._setPadding3797 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(IIII)V");
			global::android.graphics.drawable.ShapeDrawable._getPaint3798 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.ShapeDrawable._setShape3799 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShape", "(Landroid/graphics/drawable/shapes/Shape;)V");
			global::android.graphics.drawable.ShapeDrawable._inflateTag3800 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z");
			global::android.graphics.drawable.ShapeDrawable._getShape3801 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShape", "()Landroid/graphics/drawable/shapes/Shape;");
			global::android.graphics.drawable.ShapeDrawable._setShaderFactory3802 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V");
			global::android.graphics.drawable.ShapeDrawable._getShaderFactory3803 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;");
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth3804 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicWidth", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight3805 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicHeight", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3806 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable3807 = @__env.GetMethodID(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/shapes/Shape;)V");
		}
	}
}
