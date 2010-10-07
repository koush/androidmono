namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface WrapperListAdapter : ListAdapter
	{
		global::android.widget.ListAdapter getWrappedAdapter();
	}

	public partial class WrapperListAdapter_
	{
		public static global::java.lang.Class _class
		{
			get { return __WrapperListAdapter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __WrapperListAdapter : java.lang.Object, WrapperListAdapter
	{
		internal static global::java.lang.Class staticClass;
		static __WrapperListAdapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__WrapperListAdapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__WrapperListAdapter(@__env);
			}
		}
		internal __WrapperListAdapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWrappedAdapter12048;
		 global::android.widget.ListAdapter android.widget.WrapperListAdapter.getWrappedAdapter() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__WrapperListAdapter._getWrappedAdapter12048));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.widget.ListAdapter>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getWrappedAdapter12048));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEnabled12049;
		 bool android.widget.ListAdapter.isEnabled(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__WrapperListAdapter._isEnabled12049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._isEnabled12049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areAllItemsEnabled12050;
		 bool android.widget.ListAdapter.areAllItemsEnabled() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__WrapperListAdapter._areAllItemsEnabled12050);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._areAllItemsEnabled12050);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty12051;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__WrapperListAdapter._isEmpty12051);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._isEmpty12051);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount12052;
		 int android.widget.Adapter.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__WrapperListAdapter._getCount12052);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getCount12052);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver12053;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__WrapperListAdapter._registerDataSetObserver12053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._registerDataSetObserver12053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver12054;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__WrapperListAdapter._unregisterDataSetObserver12054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._unregisterDataSetObserver12054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem12055;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__WrapperListAdapter._getItem12055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getItem12055, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId12056;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__WrapperListAdapter._getItemId12056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getItemId12056, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds12057;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__WrapperListAdapter._hasStableIds12057);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._hasStableIds12057);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView12058;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__WrapperListAdapter._getView12058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getView12058, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType12059;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__WrapperListAdapter._getItemViewType12059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getItemViewType12059, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount12060;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__WrapperListAdapter._getViewTypeCount12060);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__WrapperListAdapter.staticClass, global::android.widget.__WrapperListAdapter._getViewTypeCount12060);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__WrapperListAdapter.staticClass = @__class;
			global::android.widget.__WrapperListAdapter._getWrappedAdapter12048 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.WrapperListAdapter.getWrappedAdapter", "()Landroid/widget/ListAdapter;");
			global::android.widget.__WrapperListAdapter._isEnabled12049 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.ListAdapter.isEnabled", "(I)Z");
			global::android.widget.__WrapperListAdapter._areAllItemsEnabled12050 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.ListAdapter.areAllItemsEnabled", "()Z");
			global::android.widget.__WrapperListAdapter._isEmpty12051 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.isEmpty", "()Z");
			global::android.widget.__WrapperListAdapter._getCount12052 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getCount", "()I");
			global::android.widget.__WrapperListAdapter._registerDataSetObserver12053 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__WrapperListAdapter._unregisterDataSetObserver12054 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__WrapperListAdapter._getItem12055 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;");
			global::android.widget.__WrapperListAdapter._getItemId12056 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItemId", "(I)J");
			global::android.widget.__WrapperListAdapter._hasStableIds12057 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z");
			global::android.widget.__WrapperListAdapter._getView12058 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__WrapperListAdapter._getItemViewType12059 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I");
			global::android.widget.__WrapperListAdapter._getViewTypeCount12060 = @__env.GetMethodID(global::android.widget.__WrapperListAdapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I");
		}
	}
}
