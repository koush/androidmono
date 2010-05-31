namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExpandableListActivity : android.app.Activity, android.view.View.OnCreateContextMenuListener, android.widget.ExpandableListView.OnChildClickListener, android.widget.ExpandableListView.OnGroupCollapseListener, android.widget.ExpandableListView.OnGroupExpandListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ExpandableListActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.app.ExpandableListActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.ExpandableListActivity(@__env); 
			} 
		} 
		protected ExpandableListActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState519; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onRestoreInstanceState519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onRestoreInstanceState519, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged520; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onContentChanged520); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onContentChanged520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu521; 
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onCreateContextMenu521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onCreateContextMenu521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildClick522; 
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.ExpandableListActivity._onChildClick522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onChildClick522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapse523; 
		public virtual void onGroupCollapse(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onGroupCollapse523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupCollapse523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpand524; 
		public virtual void onGroupExpand(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onGroupExpand524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupExpand524, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setListAdapter525; 
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._setListAdapter525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setListAdapter525, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListView526; 
		public virtual global::android.widget.ExpandableListView getExpandableListView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ExpandableListActivity._getExpandableListView526)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListView526)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter527; 
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ExpandableListActivity._getExpandableListAdapter527)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListAdapter527)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId528; 
		public virtual long getSelectedId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.app.ExpandableListActivity._getSelectedId528); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedId528); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition529; 
		public virtual long getSelectedPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.app.ExpandableListActivity._getSelectedPosition529); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedPosition529); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild530; 
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.app.ExpandableListActivity._setSelectedChild530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedChild530, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup531; 
		public virtual void setSelectedGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._setSelectedGroup531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedGroup531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListActivity532; 
		public ExpandableListActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._ExpandableListActivity532, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ExpandableListActivity.staticClass = @__class; 
			global::android.app.ExpandableListActivity._onRestoreInstanceState519 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.ExpandableListActivity._onContentChanged520 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V"); 
			global::android.app.ExpandableListActivity._onCreateContextMenu521 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			global::android.app.ExpandableListActivity._onChildClick522 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z"); 
			global::android.app.ExpandableListActivity._onGroupCollapse523 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V"); 
			global::android.app.ExpandableListActivity._onGroupExpand524 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V"); 
			global::android.app.ExpandableListActivity._setListAdapter525 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V"); 
			global::android.app.ExpandableListActivity._getExpandableListView526 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;"); 
			global::android.app.ExpandableListActivity._getExpandableListAdapter527 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;"); 
			global::android.app.ExpandableListActivity._getSelectedId528 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J"); 
			global::android.app.ExpandableListActivity._getSelectedPosition529 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J"); 
			global::android.app.ExpandableListActivity._setSelectedChild530 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z"); 
			global::android.app.ExpandableListActivity._setSelectedGroup531 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V"); 
			global::android.app.ExpandableListActivity._ExpandableListActivity532 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
