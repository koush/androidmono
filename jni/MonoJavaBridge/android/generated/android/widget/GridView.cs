namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class GridView : android.widget.AbsListView
	{
		internal new static global::java.lang.Class staticClass;
		static GridView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.GridView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.GridView(@__env);
			}
		}
		protected GridView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown10969;
		public override bool onKeyDown(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.GridView._onKeyDown10969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyDown10969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp10970;
		public override bool onKeyUp(int arg0, android.view.KeyEvent arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.GridView._onKeyUp10970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyUp10970, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyMultiple10971;
		public override bool onKeyMultiple(int arg0, int arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.GridView._onKeyMultiple10971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._onKeyMultiple10971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10972;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setGravity10972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setGravity10972, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onFocusChanged10973;
		protected override void onFocusChanged(bool arg0, int arg1, android.graphics.Rect arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._onFocusChanged10973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._onFocusChanged10973, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollRange10974;
		protected override int computeVerticalScrollRange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.GridView._computeVerticalScrollRange10974);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollRange10974);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollOffset10975;
		protected override int computeVerticalScrollOffset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.GridView._computeVerticalScrollOffset10975);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollOffset10975);
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeVerticalScrollExtent10976;
		protected override int computeVerticalScrollExtent() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.GridView._computeVerticalScrollExtent10976);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._computeVerticalScrollExtent10976);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10977;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._onMeasure10977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._onMeasure10977, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _attachLayoutAnimationParameters10978;
		protected override void attachLayoutAnimationParameters(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._attachLayoutAnimationParameters10978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._attachLayoutAnimationParameters10978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10979;
		public virtual void setAdapter(android.widget.ListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setAdapter10979, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter10979, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdapter10980;
		public override void setAdapter(android.widget.Adapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setAdapter10980, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setAdapter10980, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdapter10981;
		public override global::android.widget.Adapter getAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.GridView._getAdapter10981));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.Adapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._getAdapter10981));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelection10982;
		public override void setSelection(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setSelection10982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setSelection10982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _layoutChildren10983;
		protected override void layoutChildren() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._layoutChildren10983);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._layoutChildren10983);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNumColumns10984;
		public virtual void setNumColumns(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setNumColumns10984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setNumColumns10984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalSpacing10985;
		public virtual void setHorizontalSpacing(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setHorizontalSpacing10985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setHorizontalSpacing10985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalSpacing10986;
		public virtual void setVerticalSpacing(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setVerticalSpacing10986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setVerticalSpacing10986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStretchMode10987;
		public virtual void setStretchMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setStretchMode10987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setStretchMode10987, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStretchMode10988;
		public virtual int getStretchMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.GridView._getStretchMode10988);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._getStretchMode10988);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColumnWidth10989;
		public virtual void setColumnWidth(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.GridView._setColumnWidth10989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.GridView.staticClass, global::android.widget.GridView._setColumnWidth10989, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridView10990;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView10990, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridView10991;
		public GridView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView10991, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _GridView10992;
		public GridView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.GridView.staticClass, global::android.widget.GridView._GridView10992, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.GridView.staticClass = @__class;
			global::android.widget.GridView._onKeyDown10969 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyDown", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyUp10970 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyUp", "(ILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._onKeyMultiple10971 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onKeyMultiple", "(IILandroid/view/KeyEvent;)Z");
			global::android.widget.GridView._setGravity10972 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setGravity", "(I)V");
			global::android.widget.GridView._onFocusChanged10973 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onFocusChanged", "(ZILandroid/graphics/Rect;)V");
			global::android.widget.GridView._computeVerticalScrollRange10974 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollRange", "()I");
			global::android.widget.GridView._computeVerticalScrollOffset10975 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollOffset", "()I");
			global::android.widget.GridView._computeVerticalScrollExtent10976 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "computeVerticalScrollExtent", "()I");
			global::android.widget.GridView._onMeasure10977 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "onMeasure", "(II)V");
			global::android.widget.GridView._attachLayoutAnimationParameters10978 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "attachLayoutAnimationParameters", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;II)V");
			global::android.widget.GridView._setAdapter10979 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/ListAdapter;)V");
			global::android.widget.GridView._setAdapter10980 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setAdapter", "(Landroid/widget/Adapter;)V");
			global::android.widget.GridView._getAdapter10981 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "getAdapter", "()Landroid/widget/Adapter;");
			global::android.widget.GridView._setSelection10982 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setSelection", "(I)V");
			global::android.widget.GridView._layoutChildren10983 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "layoutChildren", "()V");
			global::android.widget.GridView._setNumColumns10984 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setNumColumns", "(I)V");
			global::android.widget.GridView._setHorizontalSpacing10985 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setHorizontalSpacing", "(I)V");
			global::android.widget.GridView._setVerticalSpacing10986 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setVerticalSpacing", "(I)V");
			global::android.widget.GridView._setStretchMode10987 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setStretchMode", "(I)V");
			global::android.widget.GridView._getStretchMode10988 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "getStretchMode", "()I");
			global::android.widget.GridView._setColumnWidth10989 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "setColumnWidth", "(I)V");
			global::android.widget.GridView._GridView10990 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.GridView._GridView10991 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.GridView._GridView10992 = @__env.GetMethodID(global::android.widget.GridView.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
