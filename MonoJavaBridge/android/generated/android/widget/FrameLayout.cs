namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FrameLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FrameLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._m0.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._m0 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(III)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.FrameLayout.LayoutParams._m4.native == global::System.IntPtr.Zero)
					global::android.widget.FrameLayout.LayoutParams._m4 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.LayoutParams.staticClass, global::android.widget.FrameLayout.LayoutParams._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _gravity6057;
			public int gravity
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _gravity6057);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.FrameLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout$LayoutParams"));
				global::android.widget.FrameLayout.LayoutParams._gravity6057 = @__env.GetFieldIDNoThrow(global::android.widget.FrameLayout.LayoutParams.staticClass, "gravity", "I");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setForeground(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setForeground", "(Landroid/graphics/drawable/Drawable;)V", ref global::android.widget.FrameLayout._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.widget.FrameLayout._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onSizeChanged", "(IIII)V", ref global::android.widget.FrameLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.FrameLayout._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override bool verifyDrawable(android.graphics.drawable.Drawable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "verifyDrawable", "(Landroid/graphics/drawable/Drawable;)Z", ref global::android.widget.FrameLayout._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void drawableStateChanged()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "drawableStateChanged", "()V", ref global::android.widget.FrameLayout._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "onMeasure", "(II)V", ref global::android.widget.FrameLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.FrameLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.widget.FrameLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/FrameLayout$LayoutParams;", ref global::android.widget.FrameLayout._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.FrameLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.FrameLayout._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual global::android.widget.FrameLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", ref global::android.widget.FrameLayout._m10) as android.widget.FrameLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool gatherTransparentRegion(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z", ref global::android.widget.FrameLayout._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ForegroundGravity
		{
			set
			{
				setForegroundGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setForegroundGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setForegroundGravity", "(I)V", ref global::android.widget.FrameLayout._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.graphics.drawable.Drawable Foreground
		{
			get
			{
				return getForeground();
			}
			set
			{
				setForeground(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.graphics.drawable.Drawable getForeground()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.FrameLayout.staticClass, "getForeground", "()Landroid/graphics/drawable/Drawable;", ref global::android.widget.FrameLayout._m13) as android.graphics.drawable.Drawable;
		}
		public new bool MeasureAllChildren
		{
			set
			{
				setMeasureAllChildren(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setMeasureAllChildren(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.FrameLayout.staticClass, "setMeasureAllChildren", "(Z)V", ref global::android.widget.FrameLayout._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ConsiderGoneChildrenWhenMeasuring
		{
			get
			{
				return getConsiderGoneChildrenWhenMeasuring();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool getConsiderGoneChildrenWhenMeasuring()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.FrameLayout.staticClass, "getConsiderGoneChildrenWhenMeasuring", "()Z", ref global::android.widget.FrameLayout._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._m16.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._m16 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public FrameLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._m17.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._m17 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public FrameLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.FrameLayout._m18.native == global::System.IntPtr.Zero)
				global::android.widget.FrameLayout._m18 = @__env.GetMethodIDNoThrow(global::android.widget.FrameLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.FrameLayout.staticClass, global::android.widget.FrameLayout._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FrameLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.FrameLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/FrameLayout"));
		}
	}
}
