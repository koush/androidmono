namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GradientDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GradientDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Orientation : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Orientation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.graphics.drawable.GradientDrawable.Orientation[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.drawable.GradientDrawable.Orientation._m0.native == global::System.IntPtr.Zero)
					global::android.graphics.drawable.GradientDrawable.Orientation._m0 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.drawable.GradientDrawable.Orientation>(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._m0)) as android.graphics.drawable.GradientDrawable.Orientation[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.drawable.GradientDrawable.Orientation._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.drawable.GradientDrawable.Orientation._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.CallStaticObjectMethod(android.graphics.drawable.GradientDrawable.Orientation.staticClass, global::android.graphics.drawable.GradientDrawable.Orientation._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.GradientDrawable.Orientation;
			}
			internal static global::MonoJavaBridge.FieldId _BL_TR2422;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BL_TR2422)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BOTTOM_TOP2423;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BOTTOM_TOP2423)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BR_TL2424;
			public static global::android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _BR_TL2424)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _LEFT_RIGHT2425;
			public static global::android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _LEFT_RIGHT2425)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RIGHT_LEFT2426;
			public static global::android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _RIGHT_LEFT2426)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TL_BR2427;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TL_BR2427)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TOP_BOTTOM2428;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TOP_BOTTOM2428)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TR_BL2429;
			public static global::android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.drawable.GradientDrawable.Orientation>(@__env.GetStaticObjectField(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, _TR_BL2429)) as android.graphics.drawable.GradientDrawable.Orientation;
				}
			}
			static Orientation()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable$Orientation"));
				global::android.graphics.drawable.GradientDrawable.Orientation._BL_TR2422 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BL_TR", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._BOTTOM_TOP2423 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BOTTOM_TOP", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._BR_TL2424 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "BR_TL", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._LEFT_RIGHT2425 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "LEFT_RIGHT", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._RIGHT_LEFT2426 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "RIGHT_LEFT", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TL_BR2427 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TL_BR", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TOP_BOTTOM2428 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TOP_BOTTOM", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
				global::android.graphics.drawable.GradientDrawable.Orientation._TR_BL2429 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "TR_BL", "Landroid/graphics/drawable/GradientDrawable$Orientation;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V", ref global::android.graphics.drawable.GradientDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.GradientDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.GradientDrawable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.GradientDrawable._m3);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.GradientDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.GradientDrawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.GradientDrawable._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.GradientDrawable._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z", ref global::android.graphics.drawable.GradientDrawable._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.GradientDrawable._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.GradientDrawable._m10);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.GradientDrawable._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.GradientDrawable._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.GradientDrawable._m13) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.GradientDrawable._m14) as android.graphics.drawable.Drawable.ConstantState;
		}
		public new int Color
		{
			set
			{
				setColor(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setColor(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V", ref global::android.graphics.drawable.GradientDrawable._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float[] CornerRadii
		{
			set
			{
				setCornerRadii(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setCornerRadii(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V", ref global::android.graphics.drawable.GradientDrawable._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float CornerRadius
		{
			set
			{
				setCornerRadius(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setCornerRadius(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V", ref global::android.graphics.drawable.GradientDrawable._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setStroke(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V", ref global::android.graphics.drawable.GradientDrawable._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V", ref global::android.graphics.drawable.GradientDrawable._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Shape
		{
			set
			{
				setShape(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setShape(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V", ref global::android.graphics.drawable.GradientDrawable._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int GradientType
		{
			set
			{
				setGradientType(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setGradientType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V", ref global::android.graphics.drawable.GradientDrawable._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setGradientCenter(float arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V", ref global::android.graphics.drawable.GradientDrawable._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new float GradientRadius
		{
			set
			{
				setGradientRadius(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setGradientRadius(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V", ref global::android.graphics.drawable.GradientDrawable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool UseLevel
		{
			set
			{
				setUseLevel(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setUseLevel(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V", ref global::android.graphics.drawable.GradientDrawable._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.GradientDrawable._m25.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.GradientDrawable._m25 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public GradientDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.GradientDrawable._m26.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.GradientDrawable._m26 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, global::android.graphics.drawable.GradientDrawable._m26);
			Init(@__env, handle);
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
		static GradientDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.GradientDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/GradientDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
