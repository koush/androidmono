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
			internal static global::MonoJavaBridge.MethodId _resize6198;
			public abstract global::android.graphics.Shader resize(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _ShaderFactory6199;
			public ShaderFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory6199.native == global::System.IntPtr.Zero)
					global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory6199 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory6199);
				Init(@__env, handle);
			}
			static ShaderFactory()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
			}
			internal static void InitJNI()
			{
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory))]
		internal sealed partial class ShaderFactory_ : android.graphics.drawable.ShapeDrawable.ShaderFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ShaderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _resize6200;
			public override global::android.graphics.Shader resize(int arg0, int arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass, "resize", "(II)Landroid/graphics/Shader;", ref global::android.graphics.drawable.ShapeDrawable.ShaderFactory_._resize6200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.graphics.Shader;
			}
			static ShaderFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _inflate6201;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.ShapeDrawable._inflate6201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw6202;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.graphics.drawable.ShapeDrawable._draw6202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations6203;
		public override int getChangingConfigurations()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getChangingConfigurations", "()I", ref global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations6203);
		}
		public new bool Dither
		{
			set
			{
				setDither(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setDither6204;
		public override void setDither(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setDither", "(Z)V", ref global::android.graphics.drawable.ShapeDrawable._setDither6204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha6205;
		public override void setAlpha(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setAlpha", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._setAlpha6205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.ColorFilter ColorFilter
		{
			set
			{
				setColorFilter(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter6206;
		public override void setColorFilter(android.graphics.ColorFilter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V", ref global::android.graphics.drawable.ShapeDrawable._setColorFilter6206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity6207;
		public override int getOpacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getOpacity", "()I", ref global::android.graphics.drawable.ShapeDrawable._getOpacity6207);
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange6208;
		protected override void onBoundsChange(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.ShapeDrawable._onBoundsChange6208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth6209;
		public override int getIntrinsicWidth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicWidth", "()I", ref global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth6209);
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
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight6210;
		public override int getIntrinsicHeight()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicHeight", "()I", ref global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight6210);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding6211;
		public override bool getPadding(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z", ref global::android.graphics.drawable.ShapeDrawable._getPadding6211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6212;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.ShapeDrawable._mutate6212) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState6213;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;", ref global::android.graphics.drawable.ShapeDrawable._getConstantState6213) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _onDraw6214;
		protected virtual void onDraw(android.graphics.drawable.shapes.Shape arg0, android.graphics.Canvas arg1, android.graphics.Paint arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", ref global::android.graphics.drawable.ShapeDrawable._onDraw6214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.graphics.Rect Padding
		{
			set
			{
				setPadding(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPadding6215;
		public virtual void setPadding(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(Landroid/graphics/Rect;)V", ref global::android.graphics.drawable.ShapeDrawable._setPadding6215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPadding6216;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(IIII)V", ref global::android.graphics.drawable.ShapeDrawable._setPadding6216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint6217;
		public virtual global::android.graphics.Paint getPaint()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;", ref global::android.graphics.drawable.ShapeDrawable._getPaint6217) as android.graphics.Paint;
		}
		internal static global::MonoJavaBridge.MethodId _setShape6218;
		public virtual void setShape(android.graphics.drawable.shapes.Shape arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setShape", "(Landroid/graphics/drawable/shapes/Shape;)V", ref global::android.graphics.drawable.ShapeDrawable._setShape6218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflateTag6219;
		protected virtual bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z", ref global::android.graphics.drawable.ShapeDrawable._inflateTag6219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getShape6220;
		public virtual global::android.graphics.drawable.shapes.Shape getShape()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getShape", "()Landroid/graphics/drawable/shapes/Shape;", ref global::android.graphics.drawable.ShapeDrawable._getShape6220) as android.graphics.drawable.shapes.Shape;
		}
		internal static global::MonoJavaBridge.MethodId _setShaderFactory6221;
		public virtual void setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V", ref global::android.graphics.drawable.ShapeDrawable._setShaderFactory6221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShaderFactory6222;
		public virtual global::android.graphics.drawable.ShapeDrawable.ShaderFactory getShaderFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;", ref global::android.graphics.drawable.ShapeDrawable._getShaderFactory6222) as android.graphics.drawable.ShapeDrawable.ShaderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setIntrinsicWidth6223;
		public virtual void setIntrinsicWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicWidth", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth6223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntrinsicHeight6224;
		public virtual void setIntrinsicHeight(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicHeight", "(I)V", ref global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight6224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ShapeDrawable6225;
		public ShapeDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6225.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6225 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6225);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ShapeDrawable6226;
		public ShapeDrawable(android.graphics.drawable.shapes.Shape arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6226.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6226 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/shapes/Shape;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable6226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ShapeDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ShapeDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
