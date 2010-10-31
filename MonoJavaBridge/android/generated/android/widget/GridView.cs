namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GridView : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GridView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.GridView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.GridView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.GridView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z", ref global::android.widget.GridView._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.GridView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z", ref global::android.widget.GridView._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setGravity", "(I)V", ref global::android.widget.GridView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V", ref global::android.widget.GridView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override int computeVerticalScrollRange()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.GridView.staticClass, "computeVerticalScrollRange", "()I", ref global::android.widget.GridView._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override int computeVerticalScrollOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.GridView.staticClass, "computeVerticalScrollOffset", "()I", ref global::android.widget.GridView._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override int computeVerticalScrollExtent()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.GridView.staticClass, "computeVerticalScrollExtent", "()I", ref global::android.widget.GridView._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "onMeasure", "(II)V", ref global::android.widget.GridView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V", ref global::android.widget.GridView._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setAdapter(android.widget.ListAdapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V", ref global::android.widget.GridView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void setAdapter(android.widget.Adapter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V", ref global::android.widget.GridView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.widget.Adapter Adapter
		{
			get
			{
				return getAdapter();
			}
			set
			{
				setAdapter(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::android.widget.Adapter getAdapter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.widget.Adapter>(this, global::android.widget.GridView.staticClass, "getAdapter", "()Landroid/widget/Adapter;", ref global::android.widget.GridView._m12) as android.widget.Adapter;
		}
		public new int Selection
		{
			set
			{
				setSelection(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void setSelection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setSelection", "(I)V", ref global::android.widget.GridView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected override void layoutChildren()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "layoutChildren", "()V", ref global::android.widget.GridView._m14);
		}
		public new int NumColumns
		{
			set
			{
				setNumColumns(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setNumColumns(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setNumColumns", "(I)V", ref global::android.widget.GridView._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int HorizontalSpacing
		{
			set
			{
				setHorizontalSpacing(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setHorizontalSpacing(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setHorizontalSpacing", "(I)V", ref global::android.widget.GridView._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalSpacing
		{
			set
			{
				setVerticalSpacing(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setVerticalSpacing(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setVerticalSpacing", "(I)V", ref global::android.widget.GridView._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setStretchMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setStretchMode", "(I)V", ref global::android.widget.GridView._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int StretchMode
		{
			get
			{
				return getStretchMode();
			}
			set
			{
				setStretchMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getStretchMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.GridView.staticClass, "getStretchMode", "()I", ref global::android.widget.GridView._m19);
		}
		public new int ColumnWidth
		{
			set
			{
				setColumnWidth(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setColumnWidth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.GridView.staticClass, "setColumnWidth", "(I)V", ref global::android.widget.GridView._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.GridView._m21.native == global::System.IntPtr.Zero)
				global::android.widget.GridView._m21 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.GridView._m22.native == global::System.IntPtr.Zero)
				global::android.widget.GridView._m22 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public GridView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.GridView._m23.native == global::System.IntPtr.Zero)
				global::android.widget.GridView._m23 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int NO_STRETCH
		{
			get
			{
				return 0;
			}
		}
		public static int STRETCH_SPACING
		{
			get
			{
				return 1;
			}
		}
		public static int STRETCH_COLUMN_WIDTH
		{
			get
			{
				return 2;
			}
		}
		public static int STRETCH_SPACING_UNIFORM
		{
			get
			{
				return 3;
			}
		}
		public static int AUTO_FIT
		{
			get
			{
				return -1;
			}
		}
		static GridView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.GridView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/GridView"));
		}
	}
}
