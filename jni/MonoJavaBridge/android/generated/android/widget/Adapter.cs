namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Adapter 
	{
		bool isEmpty();
		int getCount();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		global::java.lang.Object getItem(int arg0);
		long getItemId(int arg0);
		bool hasStableIds();
		global::android.view.View getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2);
		int getItemViewType(int arg0);
		int getViewTypeCount();
	}

	public partial class Adapter_
	{
		public static global::java.lang.Class _class
		{
			get { return __Adapter.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Adapter : java.lang.Object, Adapter
	{
		internal static global::java.lang.Class staticClass;
		static __Adapter()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.__Adapter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.__Adapter(@__env);
			}
		}
		internal __Adapter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty10487;
		 bool android.widget.Adapter.isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__Adapter._isEmpty10487);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._isEmpty10487);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount10488;
		 int android.widget.Adapter.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getCount10488);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getCount10488);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver10489;
		 void android.widget.Adapter.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__Adapter._registerDataSetObserver10489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._registerDataSetObserver10489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver10490;
		 void android.widget.Adapter.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.__Adapter._unregisterDataSetObserver10490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._unregisterDataSetObserver10490, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItem10491;
		 global::java.lang.Object android.widget.Adapter.getItem(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__Adapter._getItem10491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItem10491, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemId10492;
		 long android.widget.Adapter.getItemId(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.widget.__Adapter._getItemId10492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItemId10492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasStableIds10493;
		 bool android.widget.Adapter.hasStableIds() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.__Adapter._hasStableIds10493);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._hasStableIds10493);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getView10494;
		 global::android.view.View android.widget.Adapter.getView(int arg0, android.view.View arg1, android.view.ViewGroup arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.__Adapter._getView10494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getView10494, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getItemViewType10495;
		 int android.widget.Adapter.getItemViewType(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getItemViewType10495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getItemViewType10495, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getViewTypeCount10496;
		 int android.widget.Adapter.getViewTypeCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.__Adapter._getViewTypeCount10496);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.__Adapter.staticClass, global::android.widget.__Adapter._getViewTypeCount10496);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.__Adapter.staticClass = @__class;
			global::android.widget.__Adapter._isEmpty10487 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.isEmpty", "()Z");
			global::android.widget.__Adapter._getCount10488 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getCount", "()I");
			global::android.widget.__Adapter._registerDataSetObserver10489 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__Adapter._unregisterDataSetObserver10490 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.widget.__Adapter._getItem10491 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItem", "(I)Ljava/lang/Object;");
			global::android.widget.__Adapter._getItemId10492 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItemId", "(I)J");
			global::android.widget.__Adapter._hasStableIds10493 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.hasStableIds", "()Z");
			global::android.widget.__Adapter._getView10494 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.widget.__Adapter._getItemViewType10495 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getItemViewType", "(I)I");
			global::android.widget.__Adapter._getViewTypeCount10496 = @__env.GetMethodID(global::android.widget.__Adapter.staticClass, "android.widget.Adapter.getViewTypeCount", "()I");
		}
	}
}
