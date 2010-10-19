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
		internal static global::MonoJavaBridge.MethodId _onKeyDown11894;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyDown11894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyDown11894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp11895;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyUp11895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyUp11895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyMultiple11896;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.GridView._onKeyMultiple11896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyMultiple11896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity11897;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setGravity11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setGravity11897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onFocusChanged11898;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._onFocusChanged11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onFocusChanged11898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollRange11899;
		protected override int computeVerticalScrollRange() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollRange11899);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollRange11899);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollOffset11900;
		protected override int computeVerticalScrollOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollOffset11900);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollOffset11900);
		}
		internal static global::MonoJavaBridge.MethodId _computeVerticalScrollExtent11901;
		protected override int computeVerticalScrollExtent() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._computeVerticalScrollExtent11901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollExtent11901);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11902;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._onMeasure11902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._onMeasure11902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _attachLayoutAnimationParameters11903;
		protected override void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._attachLayoutAnimationParameters11903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._attachLayoutAnimationParameters11903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11904;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setAdapter11904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter11904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAdapter11905;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setAdapter11905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter11905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getAdapter11906;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.GridView._getAdapter11906)) as android.widget.Adapter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.widget.Adapter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._getAdapter11906)) as android.widget.Adapter;
		}
		internal static global::MonoJavaBridge.MethodId _setSelection11907;
		public override void setSelection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setSelection11907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setSelection11907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _layoutChildren11908;
		protected override void layoutChildren() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._layoutChildren11908);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._layoutChildren11908);
		}
		internal static global::MonoJavaBridge.MethodId _setNumColumns11909;
		public virtual void setNumColumns(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setNumColumns11909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setNumColumns11909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalSpacing11910;
		public virtual void setHorizontalSpacing(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setHorizontalSpacing11910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setHorizontalSpacing11910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalSpacing11911;
		public virtual void setVerticalSpacing(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setVerticalSpacing11911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setVerticalSpacing11911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStretchMode11912;
		public virtual void setStretchMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setStretchMode11912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setStretchMode11912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getStretchMode11913;
		public virtual int getStretchMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.GridView._getStretchMode11913);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._getStretchMode11913);
		}
		internal static global::MonoJavaBridge.MethodId _setColumnWidth11914;
		public virtual void setColumnWidth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.GridView._setColumnWidth11914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.GridView.staticClass, global::android.widget.GridView._setColumnWidth11914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _GridView11915;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView11915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridView11916;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView11916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _GridView11917;
		public GridView(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView11917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.widget.GridView._onKeyDown11894 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyUp11895 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyMultiple11896 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._setGravity11897 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setGravity", "(I)V");
			global::android.widget.GridView._onFocusChanged11898 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.GridView._computeVerticalScrollRange11899 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.GridView._computeVerticalScrollOffset11900 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.GridView._computeVerticalScrollExtent11901 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.GridView._onMeasure11902 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "onMeasure", "(II)V");
			global::android.widget.GridView._attachLayoutAnimationParameters11903 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.widget.GridView._setAdapter11904 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.GridView._setAdapter11905 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.GridView._getAdapter11906 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.GridView._setSelection11907 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setSelection", "(I)V");
			global::android.widget.GridView._layoutChildren11908 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "layoutChildren", "()V");
			global::android.widget.GridView._setNumColumns11909 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setNumColumns", "(I)V");
			global::android.widget.GridView._setHorizontalSpacing11910 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setHorizontalSpacing", "(I)V");
			global::android.widget.GridView._setVerticalSpacing11911 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setVerticalSpacing", "(I)V");
			global::android.widget.GridView._setStretchMode11912 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setStretchMode", "(I)V");
			global::android.widget.GridView._getStretchMode11913 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "getStretchMode", "()I");
			global::android.widget.GridView._setColumnWidth11914 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "setColumnWidth", "(I)V");
			global::android.widget.GridView._GridView11915 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.GridView._GridView11916 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.GridView._GridView11917 = @__env.GetMethodIDNoThrow(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
