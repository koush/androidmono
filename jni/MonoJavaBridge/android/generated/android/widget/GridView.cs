namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GridView : android.widget.AbsListView
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GridView()
		{
			InitJNI();
		}
		protected GridView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown17049;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyDown17049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyDown17049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp17050;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyUp17050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyUp17050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple17051;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyMultiple17051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyMultiple17051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17052;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setGravity17052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setGravity17052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged17053;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._onFocusChanged17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onFocusChanged17053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange17054;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollRange17054);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollRange17054);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset17055;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollOffset17055);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollOffset17055);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent17056;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollExtent17056);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollExtent17056);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17057;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._onMeasure17057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onMeasure17057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters17058;
		protected override void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._attachLayoutAnimationParameters17058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._attachLayoutAnimationParameters17058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17059;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setAdapter17059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter17059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter17060;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setAdapter17060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter17060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter17061;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.GridView._getAdapter17061)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._getAdapter17061)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection17062;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setSelection17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setSelection17062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren17063;
		protected override void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._layoutChildren17063);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._layoutChildren17063);
		}
		internal static global::MonoJavaBridge.MethodId _setNumColumns17064;
		public virtual void setNumColumns(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setNumColumns17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setNumColumns17064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalSpacing17065;
		public virtual void setHorizontalSpacing(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setHorizontalSpacing17065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setHorizontalSpacing17065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalSpacing17066;
		public virtual void setVerticalSpacing(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setVerticalSpacing17066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setVerticalSpacing17066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStretchMode17067;
		public virtual void setStretchMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setStretchMode17067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setStretchMode17067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStretchMode17068;
		public virtual int getStretchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._getStretchMode17068);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._getStretchMode17068);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnWidth17069;
		public virtual void setColumnWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setColumnWidth17069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setColumnWidth17069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridView17070;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView17070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridView17071;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView17071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridView17072;
		public GridView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView17072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.GridView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/GridView"));
			global::android.widget.GridView._onKeyDown17049 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyUp17050 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyMultiple17051 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._setGravity17052 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setGravity", "(I)V");
			global::android.widget.GridView._onFocusChanged17053 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.GridView._computeVerticalScrollRange17054 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.GridView._computeVerticalScrollOffset17055 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.GridView._computeVerticalScrollExtent17056 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.GridView._onMeasure17057 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onMeasure", "(II)V");
			global::android.widget.GridView._attachLayoutAnimationParameters17058 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.widget.GridView._setAdapter17059 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.GridView._setAdapter17060 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.GridView._getAdapter17061 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.GridView._setSelection17062 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setSelection", "(I)V");
			global::android.widget.GridView._layoutChildren17063 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "layoutChildren", "()V");
			global::android.widget.GridView._setNumColumns17064 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setNumColumns", "(I)V");
			global::android.widget.GridView._setHorizontalSpacing17065 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setHorizontalSpacing", "(I)V");
			global::android.widget.GridView._setVerticalSpacing17066 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setVerticalSpacing", "(I)V");
			global::android.widget.GridView._setStretchMode17067 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setStretchMode", "(I)V");
			global::android.widget.GridView._getStretchMode17068 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "getStretchMode", "()I");
			global::android.widget.GridView._setColumnWidth17069 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setColumnWidth", "(I)V");
			global::android.widget.GridView._GridView17070 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.GridView._GridView17071 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.GridView._GridView17072 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
