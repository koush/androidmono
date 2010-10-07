namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ImageView : android.view.View
	{
		internal new static global::java.lang.Class staticClass;
		static ImageView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ImageView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.ImageView(@__env);
			}
		}
		protected ImageView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class ScaleType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static ScaleType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.ImageView.ScaleType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.ImageView.ScaleType(@__env);
				}
			}
			internal ScaleType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values11063;
			public static global::android.widget.ImageView.ScaleType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._values11063));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf11064;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallStaticObjectMethodPtr(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._valueOf11064, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CENTER11065;
			public static global::android.widget.ImageView.ScaleType CENTER
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CENTER_CROP11066;
			public static global::android.widget.ImageView.ScaleType CENTER_CROP
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _CENTER_INSIDE11067;
			public static global::android.widget.ImageView.ScaleType CENTER_INSIDE
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FIT_CENTER11068;
			public static global::android.widget.ImageView.ScaleType FIT_CENTER
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FIT_END11069;
			public static global::android.widget.ImageView.ScaleType FIT_END
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FIT_START11070;
			public static global::android.widget.ImageView.ScaleType FIT_START
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _FIT_XY11071;
			public static global::android.widget.ImageView.ScaleType FIT_XY
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MATRIX11072;
			public static global::android.widget.ImageView.ScaleType MATRIX
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.ImageView.ScaleType.staticClass = @__class;
				global::android.widget.ImageView.ScaleType._values11063 = @__env.GetStaticMethodID(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				global::android.widget.ImageView.ScaleType._valueOf11064 = @__env.GetStaticMethodID(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDrawable11073;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ImageView._getDrawable11073));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getDrawable11073));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha11074;
		public virtual void setAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setAlpha11074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAlpha11074, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter11075;
		public virtual void setColorFilter(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setColorFilter11075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter11075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter11076;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setColorFilter11076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter11076, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter11077;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setColorFilter11077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter11077, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearColorFilter11078;
		public virtual void clearColorFilter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._clearColorFilter11078);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._clearColorFilter11078);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw11079;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._onDraw11079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onDraw11079, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _invalidateDrawable11080;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._invalidateDrawable11080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._invalidateDrawable11080, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _verifyDrawable11081;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ImageView._verifyDrawable11081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._verifyDrawable11081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged11082;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._drawableStateChanged11082);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._drawableStateChanged11082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState11083;
		public virtual new int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ImageView._onCreateDrawableState11083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onCreateDrawableState11083, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelected11084;
		public override void setSelected(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setSelected11084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setSelected11084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11085;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.ImageView._getBaseline11085);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getBaseline11085);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11086;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._onMeasure11086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onMeasure11086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSetAlpha11087;
		protected override bool onSetAlpha(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ImageView._onSetAlpha11087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onSetAlpha11087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxHeight11088;
		public virtual void setMaxHeight(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setMaxHeight11088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxHeight11088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxWidth11089;
		public virtual void setMaxWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setMaxWidth11089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxWidth11089, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFrame11090;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.ImageView._setFrame11090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setFrame11090, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdjustViewBounds11091;
		public virtual void setAdjustViewBounds(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setAdjustViewBounds11091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAdjustViewBounds11091, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageResource11092;
		public virtual void setImageResource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageResource11092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageResource11092, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageURI11093;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageURI11093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageURI11093, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageDrawable11094;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageDrawable11094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageDrawable11094, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageBitmap11095;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageBitmap11095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageBitmap11095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageState11096;
		public virtual void setImageState(int[] arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageState11096, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageState11096, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageLevel11097;
		public virtual void setImageLevel(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageLevel11097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageLevel11097, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setScaleType11098;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setScaleType11098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setScaleType11098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaleType11099;
		public virtual global::android.widget.ImageView.ScaleType getScaleType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ImageView._getScaleType11099));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ImageView.ScaleType>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getScaleType11099));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getImageMatrix11100;
		public virtual global::android.graphics.Matrix getImageMatrix() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.ImageView._getImageMatrix11100));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Matrix>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getImageMatrix11100));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setImageMatrix11101;
		public virtual void setImageMatrix(android.graphics.Matrix arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.ImageView._setImageMatrix11101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageMatrix11101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageView11102;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView11102, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageView11103;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView11103, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ImageView11104;
		public ImageView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView11104, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.ImageView.staticClass = @__class;
			global::android.widget.ImageView._getDrawable11073 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ImageView._setAlpha11074 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V");
			global::android.widget.ImageView._setColorFilter11075 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V");
			global::android.widget.ImageView._setColorFilter11076 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.widget.ImageView._setColorFilter11077 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.widget.ImageView._clearColorFilter11078 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V");
			global::android.widget.ImageView._onDraw11079 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ImageView._invalidateDrawable11080 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._verifyDrawable11081 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ImageView._drawableStateChanged11082 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ImageView._onCreateDrawableState11083 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.ImageView._setSelected11084 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V");
			global::android.widget.ImageView._getBaseline11085 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getBaseline", "()I");
			global::android.widget.ImageView._onMeasure11086 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ImageView._onSetAlpha11087 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z");
			global::android.widget.ImageView._setMaxHeight11088 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.ImageView._setMaxWidth11089 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.ImageView._setFrame11090 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.ImageView._setAdjustViewBounds11091 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V");
			global::android.widget.ImageView._setImageResource11092 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageView._setImageURI11093 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageView._setImageDrawable11094 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._setImageBitmap11095 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.widget.ImageView._setImageState11096 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V");
			global::android.widget.ImageView._setImageLevel11097 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V");
			global::android.widget.ImageView._setScaleType11098 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
			global::android.widget.ImageView._getScaleType11099 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
			global::android.widget.ImageView._getImageMatrix11100 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;");
			global::android.widget.ImageView._setImageMatrix11101 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.widget.ImageView._ImageView11102 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ImageView._ImageView11103 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ImageView._ImageView11104 = @__env.GetMethodID(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
