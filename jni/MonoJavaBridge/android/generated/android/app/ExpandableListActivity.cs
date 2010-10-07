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
		internal static global::net.sf.jni4net.jni.MethodId _onRestoreInstanceState528;
		protected override void onRestoreInstanceState(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onRestoreInstanceState528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onRestoreInstanceState528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onContentChanged529;
		public override void onContentChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onContentChanged529);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onContentChanged529);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateContextMenu530;
		public override void onCreateContextMenu(android.view.ContextMenu arg0, android.view.View arg1, android.view.ContextMenu_ContextMenuInfo arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onCreateContextMenu530, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onCreateContextMenu530, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onChildClick531;
		public virtual bool onChildClick(android.widget.ExpandableListView arg0, android.view.View arg1, int arg2, int arg3, long arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.ExpandableListActivity._onChildClick531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onChildClick531, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupCollapse532;
		public virtual void onGroupCollapse(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onGroupCollapse532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupCollapse532, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onGroupExpand533;
		public virtual void onGroupExpand(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._onGroupExpand533, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._onGroupExpand533, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setListAdapter534;
		public virtual void setListAdapter(android.widget.ExpandableListAdapter arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._setListAdapter534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setListAdapter534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListView535;
		public virtual global::android.widget.ExpandableListView getExpandableListView() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ExpandableListActivity._getExpandableListView535));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.ExpandableListView>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListView535));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExpandableListAdapter536;
		public virtual global::android.widget.ExpandableListAdapter getExpandableListAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.app.ExpandableListActivity._getExpandableListAdapter536));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ExpandableListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getExpandableListAdapter536));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedId537;
		public virtual long getSelectedId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.app.ExpandableListActivity._getSelectedId537);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedId537);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSelectedPosition538;
		public virtual long getSelectedPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.app.ExpandableListActivity._getSelectedPosition538);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._getSelectedPosition538);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedChild539;
		public virtual bool setSelectedChild(int arg0, int arg1, bool arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.app.ExpandableListActivity._setSelectedChild539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedChild539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSelectedGroup540;
		public virtual void setSelectedGroup(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.app.ExpandableListActivity._setSelectedGroup540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._setSelectedGroup540, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ExpandableListActivity541;
		public ExpandableListActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.app.ExpandableListActivity.staticClass, global::android.app.ExpandableListActivity._ExpandableListActivity541, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.app.ExpandableListActivity.staticClass = @__class;
			global::android.app.ExpandableListActivity._onRestoreInstanceState528 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onRestoreInstanceState", "(Landroid/os/Bundle;)V");
			global::android.app.ExpandableListActivity._onContentChanged529 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onContentChanged", "()V");
			global::android.app.ExpandableListActivity._onCreateContextMenu530 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V");
			global::android.app.ExpandableListActivity._onChildClick531 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z");
			global::android.app.ExpandableListActivity._onGroupCollapse532 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupCollapse", "(I)V");
			global::android.app.ExpandableListActivity._onGroupExpand533 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "onGroupExpand", "(I)V");
			global::android.app.ExpandableListActivity._setListAdapter534 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setListAdapter", "(Landroid/widget/ExpandableListAdapter;)V");
			global::android.app.ExpandableListActivity._getExpandableListView535 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListView", "()Landroid/widget/ExpandableListView;");
			global::android.app.ExpandableListActivity._getExpandableListAdapter536 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getExpandableListAdapter", "()Landroid/widget/ExpandableListAdapter;");
			global::android.app.ExpandableListActivity._getSelectedId537 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedId", "()J");
			global::android.app.ExpandableListActivity._getSelectedPosition538 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "getSelectedPosition", "()J");
			global::android.app.ExpandableListActivity._setSelectedChild539 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedChild", "(IIZ)Z");
			global::android.app.ExpandableListActivity._setSelectedGroup540 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "setSelectedGroup", "(I)V");
			global::android.app.ExpandableListActivity._ExpandableListActivity541 = @__env.GetMethodID(global::android.app.ExpandableListActivity.staticClass, "<init>", "()V");
		}
	}
}
