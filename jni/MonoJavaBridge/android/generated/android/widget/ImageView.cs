namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ImageView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ImageView()
		{
			InitJNI();
		}
		protected ImageView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class ScaleType : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ScaleType()
			{
				InitJNI();
			}
			internal ScaleType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values11988;
			public static global::android.widget.ImageView.ScaleType[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.widget.ImageView.ScaleType>(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._values11988)) as android.widget.ImageView.ScaleType[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf11989;
			public static global::android.widget.ImageView.ScaleType valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.widget.ImageView.ScaleType.staticClass, global::android.widget.ImageView.ScaleType._valueOf11989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.ImageView.ScaleType;
			}
			internal static global::MonoJavaBridge.FieldId _CENTER11990;
			public static global::android.widget.ImageView.ScaleType CENTER
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_CROP11991;
			public static global::android.widget.ImageView.ScaleType CENTER_CROP
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CENTER_INSIDE11992;
			public static global::android.widget.ImageView.ScaleType CENTER_INSIDE
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_CENTER11993;
			public static global::android.widget.ImageView.ScaleType FIT_CENTER
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_END11994;
			public static global::android.widget.ImageView.ScaleType FIT_END
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_START11995;
			public static global::android.widget.ImageView.ScaleType FIT_START
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FIT_XY11996;
			public static global::android.widget.ImageView.ScaleType FIT_XY
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			internal static global::MonoJavaBridge.FieldId _MATRIX11997;
			public static global::android.widget.ImageView.ScaleType MATRIX
			{
				get
				{
					return default(global::android.widget.ImageView.ScaleType);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ImageView.ScaleType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView$ScaleType"));
				global::android.widget.ImageView.ScaleType._values11988 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "values", "()[Landroid/widget/ImageView/ScaleType;");
				global::android.widget.ImageView.ScaleType._valueOf11989 = @__env.GetStaticMethodIDNoThrow(global::android.widget.ImageView.ScaleType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/widget/ImageView$ScaleType;");
			}
		}
		public new global::android.graphics.drawable.Drawable Drawable
		{
			get
			{
				return getDrawable();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable11998;
		public virtual global::android.graphics.drawable.Drawable getDrawable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getDrawable11998)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getDrawable11998)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha11999;
		public virtual void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAlpha11999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAlpha11999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter12000;
		public virtual void setColorFilter(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter12000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter12000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter12001;
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter12001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter12001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter12002;
		public virtual void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setColorFilter12002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setColorFilter12002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearColorFilter12003;
		public virtual void clearColorFilter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._clearColorFilter12003);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._clearColorFilter12003);
		}
		internal static global::MonoJavaBridge.MethodId _onDraw12004;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onDraw12004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onDraw12004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _invalidateDrawable12005;
		public override void invalidateDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._invalidateDrawable12005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._invalidateDrawable12005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _verifyDrawable12006;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._verifyDrawable12006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._verifyDrawable12006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawableStateChanged12007;
		protected override void drawableStateChanged() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._drawableStateChanged12007);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._drawableStateChanged12007);
		}
		internal static global::MonoJavaBridge.MethodId _onCreateDrawableState12008;
		public virtual int[] onCreateDrawableState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._onCreateDrawableState12008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onCreateDrawableState12008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setSelected12009;
		public override void setSelected(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setSelected12009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setSelected12009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12010;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.ImageView._getBaseline12010);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getBaseline12010);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12011;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._onMeasure12011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onMeasure12011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onSetAlpha12012;
		protected override bool onSetAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._onSetAlpha12012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._onSetAlpha12012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxHeight12013;
		public virtual void setMaxHeight(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxHeight12013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxHeight12013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxWidth12014;
		public virtual void setMaxWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setMaxWidth12014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setMaxWidth12014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFrame12015;
		protected virtual bool setFrame(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.ImageView._setFrame12015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setFrame12015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setAdjustViewBounds12016;
		public virtual void setAdjustViewBounds(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setAdjustViewBounds12016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setAdjustViewBounds12016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageResource12017;
		public virtual void setImageResource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageResource12017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageResource12017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageURI12018;
		public virtual void setImageURI(android.net.Uri arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageURI12018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageURI12018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageDrawable12019;
		public virtual void setImageDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageDrawable12019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageDrawable12019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageBitmap12020;
		public virtual void setImageBitmap(android.graphics.Bitmap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageBitmap12020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageBitmap12020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setImageState12021;
		public virtual void setImageState(int[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageState12021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageState12021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setImageLevel12022;
		public virtual void setImageLevel(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageLevel12022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageLevel12022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setScaleType12023;
		public virtual void setScaleType(android.widget.ImageView.ScaleType arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setScaleType12023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setScaleType12023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getScaleType12024;
		public virtual global::android.widget.ImageView.ScaleType getScaleType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getScaleType12024)) as android.widget.ImageView.ScaleType;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getScaleType12024)) as android.widget.ImageView.ScaleType;
		}
		public new global::android.graphics.Matrix ImageMatrix
		{
			get
			{
				return getImageMatrix();
			}
			set
			{
				setImageMatrix(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getImageMatrix12025;
		public virtual global::android.graphics.Matrix getImageMatrix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ImageView._getImageMatrix12025)) as android.graphics.Matrix;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._getImageMatrix12025)) as android.graphics.Matrix;
		}
		internal static global::MonoJavaBridge.MethodId _setImageMatrix12026;
		public virtual void setImageMatrix(android.graphics.Matrix arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ImageView._setImageMatrix12026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ImageView.staticClass, global::android.widget.ImageView._setImageMatrix12026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ImageView12027;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView12027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView12028;
		public ImageView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView12028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ImageView12029;
		public ImageView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ImageView.staticClass, global::android.widget.ImageView._ImageView12029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ImageView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ImageView"));
			global::android.widget.ImageView._getDrawable11998 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;");
			global::android.widget.ImageView._setAlpha11999 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAlpha", "(I)V");
			global::android.widget.ImageView._setColorFilter12000 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(I)V");
			global::android.widget.ImageView._setColorFilter12001 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V");
			global::android.widget.ImageView._setColorFilter12002 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.widget.ImageView._clearColorFilter12003 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "clearColorFilter", "()V");
			global::android.widget.ImageView._onDraw12004 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.ImageView._invalidateDrawable12005 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._verifyDrawable12006 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z");
			global::android.widget.ImageView._drawableStateChanged12007 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.ImageView._onCreateDrawableState12008 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.ImageView._setSelected12009 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setSelected", "(Z)V");
			global::android.widget.ImageView._getBaseline12010 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getBaseline", "()I");
			global::android.widget.ImageView._onMeasure12011 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onMeasure", "(II)V");
			global::android.widget.ImageView._onSetAlpha12012 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "onSetAlpha", "(I)Z");
			global::android.widget.ImageView._setMaxHeight12013 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxHeight", "(I)V");
			global::android.widget.ImageView._setMaxWidth12014 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setMaxWidth", "(I)V");
			global::android.widget.ImageView._setFrame12015 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setFrame", "(IIII)Z");
			global::android.widget.ImageView._setAdjustViewBounds12016 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setAdjustViewBounds", "(Z)V");
			global::android.widget.ImageView._setImageResource12017 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageResource", "(I)V");
			global::android.widget.ImageView._setImageURI12018 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageURI", "(Landroid/net/Uri;)V");
			global::android.widget.ImageView._setImageDrawable12019 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.ImageView._setImageBitmap12020 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			global::android.widget.ImageView._setImageState12021 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageState", "([IZ)V");
			global::android.widget.ImageView._setImageLevel12022 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageLevel", "(I)V");
			global::android.widget.ImageView._setScaleType12023 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setScaleType", "(Landroid/widget/ImageView$ScaleType;)V");
			global::android.widget.ImageView._getScaleType12024 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getScaleType", "()Landroid/widget/ImageView$ScaleType;");
			global::android.widget.ImageView._getImageMatrix12025 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "getImageMatrix", "()Landroid/graphics/Matrix;");
			global::android.widget.ImageView._setImageMatrix12026 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "setImageMatrix", "(Landroid/graphics/Matrix;)V");
			global::android.widget.ImageView._ImageView12027 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.ImageView._ImageView12028 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.ImageView._ImageView12029 = @__env.GetMethodIDNoThrow(global::android.widget.ImageView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
