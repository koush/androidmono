namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ExpandableListActivity : android.app.Activity, android.view.View.OnCreateContextMenuListener, android.widget.ExpandableListView.OnChildClickListener, android.widget.ExpandableListView.OnGroupCollapseListener, android.widget.ExpandableListView.OnGroupExpandListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ExpandableListActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ExpandableListActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState511; 
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _onRestoreInstanceState511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _onRestoreInstanceState511, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged512; 
		public override void onContentChanged() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _onContentChanged512); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _onContentChanged512); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu513; 
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _onCreateContextMenu513, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _onCreateContextMenu513, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChildClick514; 
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return @__env.CallBooleanMethod(this, _onChildClick514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.ExpandableListActivity.staticClass, _onChildClick514, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapse515; 
		public virtual void onGroupCollapse(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _onGroupCollapse515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _onGroupCollapse515, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpand516; 
		public virtual void onGroupExpand(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _onGroupExpand516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _onGroupExpand516, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setListAdapter517; 
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _setListAdapter517, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _setListAdapter517, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListView518; 
		public virtual android.widget.ExpandableListView getExpandableListView() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallObjectMethodPtr(this, _getExpandableListView518)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ExpandableListActivity.staticClass, _getExpandableListView518)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter519; 
		public virtual android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, _getExpandableListAdapter519)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.app.ExpandableListActivity.staticClass, _getExpandableListAdapter519)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId520; 
		public virtual long getSelectedId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return @__env.CallLongMethod(this, _getSelectedId520); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.app.ExpandableListActivity.staticClass, _getSelectedId520); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition521; 
		public virtual long getSelectedPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return @__env.CallLongMethod(this, _getSelectedPosition521); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.app.ExpandableListActivity.staticClass, _getSelectedPosition521); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild522; 
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				return @__env.CallBooleanMethod(this, _setSelectedChild522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.ExpandableListActivity.staticClass, _setSelectedChild522, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup523; 
		public virtual void setSelectedGroup(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ExpandableListActivity)) 
				@__env.CallVoidMethod(this, _setSelectedGroup523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ExpandableListActivity.staticClass, _setSelectedGroup523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListActivity524; 
		public ExpandableListActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ExpandableListActivity.staticClass, _ExpandableListActivity524, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ExpandableListActivity.staticClass = @__class; 
			global::android.app.ExpandableListActivity._onRestoreInstanceState511 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V"); 
			global::android.app.ExpandableListActivity._onContentChanged512 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V"); 
			global::android.app.ExpandableListActivity._onCreateContextMenu513 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V"); 
			global::android.app.ExpandableListActivity._onChildClick514 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z"); 
			global::android.app.ExpandableListActivity._onGroupCollapse515 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V"); 
			global::android.app.ExpandableListActivity._onGroupExpand516 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V"); 
			global::android.app.ExpandableListActivity._setListAdapter517 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V"); 
			global::android.app.ExpandableListActivity._getExpandableListView518 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;"); 
			global::android.app.ExpandableListActivity._getExpandableListAdapter519 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;"); 
			global::android.app.ExpandableListActivity._getSelectedId520 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J"); 
			global::android.app.ExpandableListActivity._getSelectedPosition521 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J"); 
			global::android.app.ExpandableListActivity._setSelectedChild522 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z"); 
			global::android.app.ExpandableListActivity._setSelectedGroup523 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V"); 
			global::android.app.ExpandableListActivity._ExpandableListActivity524 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
