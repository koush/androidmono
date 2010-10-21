namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.SortedSet_))]
	public interface SortedSet : Set
	{
		global::java.lang.Object last();
		global::java.lang.Object first();
		global::java.util.Comparator comparator();
		global::java.util.SortedSet subSet(java.lang.Object arg0, java.lang.Object arg1);
		global::java.util.SortedSet headSet(java.lang.Object arg0);
		global::java.util.SortedSet tailSet(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.SortedSet))]
	public sealed partial class SortedSet_ : java.lang.Object, SortedSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SortedSet_()
		{
			InitJNI();
		}
		internal SortedSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _last26663;
		 global::java.lang.Object java.util.SortedSet.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._last26663)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._last26663)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _first26664;
		 global::java.lang.Object java.util.SortedSet.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._first26664)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._first26664)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _comparator26665;
		 global::java.util.Comparator java.util.SortedSet.comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._comparator26665)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._comparator26665)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _subSet26666;
		 global::java.util.SortedSet java.util.SortedSet.subSet(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._subSet26666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._subSet26666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _headSet26667;
		 global::java.util.SortedSet java.util.SortedSet.headSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._headSet26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._headSet26667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _tailSet26668;
		 global::java.util.SortedSet java.util.SortedSet.tailSet(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._tailSet26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._tailSet26668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _add26669;
		 bool java.util.Set.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add26669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add26669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26670;
		 bool java.util.Set.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals26670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26671;
		 int java.util.Set.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode26671);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode26671);
		}
		internal static global::MonoJavaBridge.MethodId _clear26672;
		 void java.util.Set.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear26672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear26672);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26673;
		 bool java.util.Set.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty26673);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty26673);
		}
		internal static global::MonoJavaBridge.MethodId _contains26674;
		 bool java.util.Set.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains26674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains26674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26675;
		 bool java.util.Set.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll26675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll26675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26676;
		 int java.util.Set.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size26676);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size26676);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26677;
		 global::java.lang.Object[] java.util.Set.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26677)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26677)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26678;
		 global::java.lang.Object[] java.util.Set.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26679;
		 global::java.util.Iterator java.util.Set.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26679)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26679)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26680;
		 bool java.util.Set.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove26680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove26680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26681;
		 bool java.util.Set.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll26681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll26681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26682;
		 bool java.util.Set.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll26682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll26682, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26683;
		 bool java.util.Set.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll26683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll26683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add26684;
		 bool java.util.Collection.add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._add26684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._add26684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals26685;
		 bool java.util.Collection.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._equals26685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._equals26685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26686;
		 int java.util.Collection.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._hashCode26686);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._hashCode26686);
		}
		internal static global::MonoJavaBridge.MethodId _clear26687;
		 void java.util.Collection.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.SortedSet_._clear26687);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._clear26687);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26688;
		 bool java.util.Collection.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._isEmpty26688);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._isEmpty26688);
		}
		internal static global::MonoJavaBridge.MethodId _contains26689;
		 bool java.util.Collection.contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._contains26689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._contains26689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll26690;
		 bool java.util.Collection.addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._addAll26690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._addAll26690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26691;
		 int java.util.Collection.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.SortedSet_._size26691);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._size26691);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26692;
		 global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26692, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26693;
		 global::java.lang.Object[] java.util.Collection.toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._toArray26693)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._toArray26693)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator26694;
		 global::java.util.Iterator java.util.Collection.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26694)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26694)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26695;
		 bool java.util.Collection.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._remove26695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._remove26695, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll26696;
		 bool java.util.Collection.containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._containsAll26696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._containsAll26696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll26697;
		 bool java.util.Collection.removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._removeAll26697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._removeAll26697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll26698;
		 bool java.util.Collection.retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.SortedSet_._retainAll26698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._retainAll26698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _iterator26699;
		 global::java.util.Iterator java.lang.Iterable.iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.SortedSet_._iterator26699)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.SortedSet_.staticClass, global::java.util.SortedSet_._iterator26699)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.SortedSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/SortedSet"));
			global::java.util.SortedSet_._last26663 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "last", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._first26664 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "first", "()Ljava/lang/Object;");
			global::java.util.SortedSet_._comparator26665 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.SortedSet_._subSet26666 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "subSet", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._headSet26667 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "headSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._tailSet26668 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "tailSet", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			global::java.util.SortedSet_._add26669 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals26670 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode26671 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear26672 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty26673 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains26674 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll26675 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size26676 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray26677 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray26678 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator26679 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove26680 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll26681 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll26682 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll26683 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._add26684 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._equals26685 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._hashCode26686 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "hashCode", "()I");
			global::java.util.SortedSet_._clear26687 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "clear", "()V");
			global::java.util.SortedSet_._isEmpty26688 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "isEmpty", "()Z");
			global::java.util.SortedSet_._contains26689 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._addAll26690 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._size26691 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "size", "()I");
			global::java.util.SortedSet_._toArray26692 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.SortedSet_._toArray26693 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.SortedSet_._iterator26694 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.SortedSet_._remove26695 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.SortedSet_._containsAll26696 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._removeAll26697 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._retainAll26698 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.SortedSet_._iterator26699 = @__env.GetMethodIDNoThrow(global::java.util.SortedSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
