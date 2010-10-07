namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GradientDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::java.lang.Class staticClass;
		static GradientDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.GradientDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.GradientDrawable(@__env);
			}
		}
		protected GradientDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Orientation : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Orientation()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.GradientDrawable.Orientation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.graphics.drawable.GradientDrawable.Orientation(@__env);
				}
			}
			internal Orientation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values3814;
			public static global::android.graphics.drawable.GradientDrawable.Orientation[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._values3814));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3815;
			public static global::android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.GradientDrawable.Orientation>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._valueOf3815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BL_TR3816;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _BOTTOM_TOP3817;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _BR_TL3818;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _LEFT_RIGHT3819;
			public static global::android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT_LEFT3820;
			public static global::android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TL_BR3821;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TOP_BOTTOM3822;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _TR_BL3823;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{
				get
				{
					return default(global::android.graphics.drawable.GradientDrawable.Orientation);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__class;
				global::android.graphics.drawable.GradientDrawable.Orientation._values3814 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._valueOf3815 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSize3824;
		public virtual void setSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setSize3824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setSize3824, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3825;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._inflate3825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._inflate3825, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _draw3826;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._draw3826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._draw3826, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3827;
		public override int getChangingConfigurations() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations3827);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getChangingConfigurations3827);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDither3828;
		public override void setDither(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setDither3828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setDither3828, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3829;
		public override void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setAlpha3829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setAlpha3829, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3830;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setColorFilter3830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColorFilter3830, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3831;
		public override int getOpacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable._getOpacity3831);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getOpacity3831);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3832;
		protected override bool onLevelChange(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.GradientDrawable._onLevelChange3832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onLevelChange3832, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3833;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._onBoundsChange3833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._onBoundsChange3833, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3834;
		public override int getIntrinsicWidth() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth3834);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth3834);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3835;
		public override int getIntrinsicHeight() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight3835);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight3835);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3836;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.GradientDrawable._getPadding3836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getPadding3836, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3837;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.GradientDrawable._mutate3837));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._mutate3837));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3838;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.GradientDrawable._getConstantState3838));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._getConstantState3838));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColor3839;
		public virtual void setColor(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setColor3839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setColor3839, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadii3840;
		public virtual void setCornerRadii(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setCornerRadii3840, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadii3840, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadius3841;
		public virtual void setCornerRadius(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setCornerRadius3841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setCornerRadius3841, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3842;
		public virtual void setStroke(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setStroke3842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke3842, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3843;
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setStroke3843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setStroke3843, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShape3844;
		public virtual void setShape(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setShape3844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setShape3844, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGradientType3845;
		public virtual void setGradientType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setGradientType3845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientType3845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGradientCenter3846;
		public virtual void setGradientCenter(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setGradientCenter3846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientCenter3846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGradientRadius3847;
		public virtual void setGradientRadius(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setGradientRadius3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setGradientRadius3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUseLevel3848;
		public virtual void setUseLevel(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable._setUseLevel3848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._setUseLevel3848, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3849;
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable3849, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3850;
		public GradientDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._GradientDrawable3850, this);
		}
		public static int RECTANGLE
		{
			get
			{
				return 0;
			}
		}
		public static int OVAL
		{
			get
			{
				return 1;
			}
		}
		public static int LINE
		{
			get
			{
				return 2;
			}
		}
		public static int RING
		{
			get
			{
				return 3;
			}
		}
		public static int LINEAR_GRADIENT
		{
			get
			{
				return 0;
			}
		}
		public static int RADIAL_GRADIENT
		{
			get
			{
				return 1;
			}
		}
		public static int SWEEP_GRADIENT
		{
			get
			{
				return 2;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.GradientDrawable.staticClass = @__class;
			global::android.graphics.drawable.GradientDrawable._setSize3824 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V");
			global::android.graphics.drawable.GradientDrawable._inflate3825 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.GradientDrawable._draw3826 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.GradientDrawable._getChangingConfigurations3827 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.GradientDrawable._setDither3828 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._setAlpha3829 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setColorFilter3830 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.GradientDrawable._getOpacity3831 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.GradientDrawable._onLevelChange3832 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.GradientDrawable._onBoundsChange3833 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth3834 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight3835 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.GradientDrawable._getPadding3836 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.GradientDrawable._mutate3837 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.GradientDrawable._getConstantState3838 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.GradientDrawable._setColor3839 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadii3840 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V");
			global::android.graphics.drawable.GradientDrawable._setCornerRadius3841 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setStroke3842 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V");
			global::android.graphics.drawable.GradientDrawable._setStroke3843 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V");
			global::android.graphics.drawable.GradientDrawable._setShape3844 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientType3845 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V");
			global::android.graphics.drawable.GradientDrawable._setGradientCenter3846 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V");
			global::android.graphics.drawable.GradientDrawable._setGradientRadius3847 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V");
			global::android.graphics.drawable.GradientDrawable._setUseLevel3848 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3849 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V");
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3850 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V");
		}
	}
}
