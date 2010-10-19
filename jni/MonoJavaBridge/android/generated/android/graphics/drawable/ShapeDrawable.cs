namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ShapeDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ShapeDrawable()
		{
			InitJNI();
		}
		protected ShapeDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory_))]
		public abstract partial class ShaderFactory : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ShaderFactory()
			{
				InitJNI();
			}
			protected ShaderFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _resize4185;
			public abstract global::android.graphics.Shader resize(int arg0, int arg1);
			internal static global::MonoJavaBridge.MethodId _ShaderFactory4186;
			public ShaderFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory4186);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._resize4185 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "resize", "(II)Landroid/graphics/Shader;");
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory._ShaderFactory4186 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.ShaderFactory.staticClass, "<init>", "()V");
			}
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.graphics.drawable.ShapeDrawable.ShaderFactory))]
		public sealed partial class ShaderFactory_ : android.graphics.drawable.ShapeDrawable.ShaderFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ShaderFactory_()
			{
				InitJNI();
			}
			internal ShaderFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _resize4187;
			public override global::android.graphics.Shader resize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.ShaderFactory_._resize4187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Shader;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass, global::android.graphics.drawable.ShapeDrawable.ShaderFactory_._resize4187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Shader;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable$ShaderFactory"));
				global::android.graphics.drawable.ShapeDrawable.ShaderFactory_._resize4187 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.ShaderFactory_.staticClass, "resize", "(II)Landroid/graphics/Shader;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _inflate4188;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._inflate4188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._inflate4188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw4189;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._draw4189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._draw4189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations4190;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations4190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations4190);
		}
		internal static global::MonoJavaBridge.MethodId _setDither4191;
		public override void setDither(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setDither4191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setDither4191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha4192;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setAlpha4192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setAlpha4192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter4193;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setColorFilter4193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setColorFilter4193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity4194;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getOpacity4194);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getOpacity4194);
		}
		internal static global::MonoJavaBridge.MethodId _onBoundsChange4195;
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._onBoundsChange4195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._onBoundsChange4195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getIntrinsicWidth4196;
		public override int getIntrinsicWidth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth4196);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth4196);
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
		internal static global::MonoJavaBridge.MethodId _getIntrinsicHeight4197;
		public override int getIntrinsicHeight() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight4197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight4197);
		}
		internal static global::MonoJavaBridge.MethodId _getPadding4198;
		public override bool getPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getPadding4198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getPadding4198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate4199;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._mutate4199)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._mutate4199)) as android.graphics.drawable.Drawable;
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState4200;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getConstantState4200)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getConstantState4200)) as android.graphics.drawable.Drawable.ConstantState;
		}
		internal static global::MonoJavaBridge.MethodId _onDraw4201;
		protected virtual void onDraw(android.graphics.drawable.shapes.Shape arg0, android.graphics.Canvas arg1, android.graphics.Paint arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._onDraw4201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._onDraw4201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setPadding4202;
		public virtual void setPadding(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setPadding4202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setPadding4202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPadding4203;
		public virtual void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setPadding4203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setPadding4203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new global::android.graphics.Paint Paint
		{
			get
			{
				return getPaint();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPaint4204;
		public virtual global::android.graphics.Paint getPaint() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getPaint4204)) as android.graphics.Paint;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getPaint4204)) as android.graphics.Paint;
		}
		internal static global::MonoJavaBridge.MethodId _setShape4205;
		public virtual void setShape(android.graphics.drawable.shapes.Shape arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setShape4205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setShape4205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflateTag4206;
		protected virtual bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._inflateTag4206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._inflateTag4206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getShape4207;
		public virtual global::android.graphics.drawable.shapes.Shape getShape() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getShape4207)) as android.graphics.drawable.shapes.Shape;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getShape4207)) as android.graphics.drawable.shapes.Shape;
		}
		internal static global::MonoJavaBridge.MethodId _setShaderFactory4208;
		public virtual void setShaderFactory(android.graphics.drawable.ShapeDrawable.ShaderFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setShaderFactory4208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setShaderFactory4208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShaderFactory4209;
		public virtual global::android.graphics.drawable.ShapeDrawable.ShaderFactory getShaderFactory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._getShaderFactory4209)) as android.graphics.drawable.ShapeDrawable.ShaderFactory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._getShaderFactory4209)) as android.graphics.drawable.ShapeDrawable.ShaderFactory;
		}
		internal static global::MonoJavaBridge.MethodId _setIntrinsicWidth4210;
		public virtual void setIntrinsicWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth4210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth4210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIntrinsicHeight4211;
		public virtual void setIntrinsicHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight4211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight4211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ShapeDrawable4212;
		public ShapeDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable4212);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ShapeDrawable4213;
		public ShapeDrawable(android.graphics.drawable.shapes.Shape arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ShapeDrawable.staticClass, global::android.graphics.drawable.ShapeDrawable._ShapeDrawable4213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ShapeDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ShapeDrawable"));
			global::android.graphics.drawable.ShapeDrawable._inflate4188 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ShapeDrawable._draw4189 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ShapeDrawable._getChangingConfigurations4190 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ShapeDrawable._setDither4191 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setDither", "(Z)V");
			global::android.graphics.drawable.ShapeDrawable._setAlpha4192 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._setColorFilter4193 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ShapeDrawable._getOpacity4194 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ShapeDrawable._onBoundsChange4195 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicWidth4196 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicWidth", "()I");
			global::android.graphics.drawable.ShapeDrawable._getIntrinsicHeight4197 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getIntrinsicHeight", "()I");
			global::android.graphics.drawable.ShapeDrawable._getPadding4198 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z");
			global::android.graphics.drawable.ShapeDrawable._mutate4199 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.ShapeDrawable._getConstantState4200 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ShapeDrawable._onDraw4201 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "onDraw", "(Landroid/graphics/drawable/shapes/Shape;Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
			global::android.graphics.drawable.ShapeDrawable._setPadding4202 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(Landroid/graphics/Rect;)V");
			global::android.graphics.drawable.ShapeDrawable._setPadding4203 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setPadding", "(IIII)V");
			global::android.graphics.drawable.ShapeDrawable._getPaint4204 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getPaint", "()Landroid/graphics/Paint;");
			global::android.graphics.drawable.ShapeDrawable._setShape4205 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShape", "(Landroid/graphics/drawable/shapes/Shape;)V");
			global::android.graphics.drawable.ShapeDrawable._inflateTag4206 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z");
			global::android.graphics.drawable.ShapeDrawable._getShape4207 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShape", "()Landroid/graphics/drawable/shapes/Shape;");
			global::android.graphics.drawable.ShapeDrawable._setShaderFactory4208 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setShaderFactory", "(Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;)V");
			global::android.graphics.drawable.ShapeDrawable._getShaderFactory4209 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "getShaderFactory", "()Landroid/graphics/drawable/ShapeDrawable$ShaderFactory;");
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicWidth4210 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicWidth", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._setIntrinsicHeight4211 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "setIntrinsicHeight", "(I)V");
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable4212 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.ShapeDrawable._ShapeDrawable4213 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ShapeDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/shapes/Shape;)V");
		}
	}
}
