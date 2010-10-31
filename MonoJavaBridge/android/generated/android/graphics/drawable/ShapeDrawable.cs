namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ShapeDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ShapeDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory_))]
		public abstract partial class ShaderFactory : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ShaderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public abstract global::android.graphics.Shader resize(int arg0, int arg1);
			private static global::MonoJavaBridge.MethodId _m1;
			public ShaderFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.drawable.ShapeDrawable.ShaderFactory._m1.native == global::System.IntPtr.Zero)
					global::android.graphics.drawable.ShapeDrawable.ShaderFactory._m1 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, global::android.graphics.drawable.ShapeDrawable.ShaderFactory._m1);
				Init(@__env, handle);
			}
			static ShaderFactory()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory))]
		internal sealed partial class ShaderFactory_ : android.graphics.drawable.ShapeDrawable.ShaderFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ShaderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::android.graphics.Shader resize(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass, "resize", "(II)Landroid/graphics/Shader;", ref global::android.graphics.drawable.ShapeDrawable.ShaderFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Shader;
			}
			static ShaderFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.ShapeDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.ShapeDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.ShapeDrawable._m2);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.ShapeDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.ShapeDrawable._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.ShapeDrawable._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.ShapeDrawable._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IntrinsicWidth
		{
			get
			{
				return getIntrinsicWidth();
			}
			set
			{
				setIntrinsicWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.ShapeDrawable._m8);
		}
		public new int IntrinsicHeight
		{
			get
			{
				return getIntrinsicHeight();
			}
			set
			{
				setIntrinsicHeight(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.ShapeDrawable._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.ShapeDrawable._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.ShapeDrawable._m11) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.ShapeDrawable._m12) as android.graphics.drawable.Drawable.ConstantState;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected virtual void onDraw(android.graphics.drawable.shapes.Shape arg0, android.graphics.Canvas arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.ShapeDrawable._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.graphics.Rect Padding
		{
			set
			{
				setPadding(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.ShapeDrawable._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(IIII)V", ref global::android.graphics.drawable.ShapeDrawable._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::android.graphics.Paint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;", ref global::android.graphics.drawable.ShapeDrawable._m16) as android.graphics.Paint;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setShape(android.graphics.drawable.shapes.Shape arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", ref global::android.graphics.drawable.ShapeDrawable._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z", ref global::android.graphics.drawable.ShapeDrawable._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.drawable.shapes.Shape Shape
		{
			get
			{
				return getShape();
			}
			set
			{
				setShape(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual global::android.graphics.drawable.shapes.Shape getShape()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getShape", "()Landroid/graphics/drawable/shapes/Shape;", ref global::android.graphics.drawable.ShapeDrawable._m19) as android.graphics.drawable.shapes.Shape;
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V", ref global::android.graphics.drawable.ShapeDrawable._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual global::android.graphics.drawable.ShapeDrawable.ShaderFactory getShaderFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;", ref global::android.graphics.drawable.ShapeDrawable._m21) as android.graphics.drawable.ShapeDrawable.ShaderFactory;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setIntrinsicWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicWidth", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setIntrinsicHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicHeight", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public ShapeDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.ShapeDrawable._m24.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.ShapeDrawable._m24 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._m24);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public ShapeDrawable(android.graphics.drawable.shapes.Shape arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.ShapeDrawable._m25.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.ShapeDrawable._m25 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/shapes/Shape;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ShapeDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ShapeDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable"));
		}
	}
}
