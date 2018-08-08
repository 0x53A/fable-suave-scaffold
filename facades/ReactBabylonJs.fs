// ts2fable 0.0.0
module rec ReactBabylonJs
open System
open Fable.Core
open Fable.Import.JS
open Fable.Import.Browser
open Fable.Import

module ArcRotateCamera =
    type Scene = Babylonjs.BABYLON.Scene
    type BabylonArcRotateCamera = Babylonjs.BABYLON.ArcRotateCamera
    type Camera = Babylonjs.BABYLON.Camera
    type Vector3 = Babylonjs.BABYLON.Vector3
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type CameraProps = CameraProps.CameraProps

    type [<AllowNullLiteral>] IExports =
        abstract ArcRotateCamera: ArcRotateCameraStatic

    type [<AllowNullLiteral>] ArcRotateCameraProps =
        interface end

    type [<AllowNullLiteral>] ArcRotateCamera =
        inherit SceneComponent.SceneComponent<BabylonArcRotateCamera, Camera, ArcRotateCameraProps>
        abstract camera: obj option with get, set
        abstract create: scene: Scene -> BabylonArcRotateCamera
        abstract propsHandlers: ResizeArray<CameraProps.CameraPropsHandler>

    type [<AllowNullLiteral>] ArcRotateCameraStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ArcRotateCamera

module Box =
    type Scene = Babylonjs.BABYLON.Scene
    type Node = Babylonjs.BABYLON.Node
    type Mesh = Babylonjs.BABYLON.Mesh
    type Vector4 = Babylonjs.BABYLON.Vector4
    type Color4 = Babylonjs.BABYLON.Color4
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type MeshProps = MeshProps.MeshProps

    type [<AllowNullLiteral>] IExports =
        abstract Box: BoxStatic

    type [<AllowNullLiteral>] BoxProps =
        interface end

    type [<AllowNullLiteral>] Box =
        inherit SceneComponent.SceneComponent<Mesh, Node, BoxProps>
        abstract options: obj option with get, set
        abstract box: obj option with get, set
        abstract componentWillReceiveProps: unit -> unit
        abstract create: scene: Scene -> Mesh
        abstract propsHandlers: ResizeArray<MeshProps.MeshPropsHandler>

    type [<AllowNullLiteral>] BoxStatic =
        [<Emit "new $0($1...)">] abstract Create: props: BoxProps -> Box

module CameraProps =
    type PropsHandler<'T1, 'T2> = SceneComponent.PropsHandler<'T1, 'T2>
    type NodeProps = SceneComponent.NodeProps
    type Camera = Babylonjs.BABYLON.Camera

    type [<AllowNullLiteral>] IExports =
        abstract CameraPropsHandler: CameraPropsHandlerStatic

    type [<AllowNullLiteral>] CameraProps =
        interface end

    type [<AllowNullLiteral>] CameraPropsHandler =
        inherit PropsHandler<Camera, CameraProps>
        abstract handle: camera: Camera * props: CameraProps -> unit

    type [<AllowNullLiteral>] CameraPropsHandlerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> CameraPropsHandler

module FreeCamera =
    type Scene = Babylonjs.BABYLON.Scene
    type BabylonFreeCamera = Babylonjs.BABYLON.FreeCamera
    type Camera = Babylonjs.BABYLON.Camera
    type Vector3 = Babylonjs.BABYLON.Vector3
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type CameraProps = CameraProps.CameraProps

    type [<AllowNullLiteral>] IExports =
        abstract FreeCamera: FreeCameraStatic

    type [<AllowNullLiteral>] FreeCameraProps =
        interface end

    type [<AllowNullLiteral>] FreeCamera =
        inherit SceneComponent.SceneComponent<BabylonFreeCamera, Camera, FreeCameraProps>
        abstract camera: obj option with get, set
        abstract create: scene: Scene -> BabylonFreeCamera
        abstract propsHandlers: ResizeArray<CameraProps.CameraPropsHandler>
        abstract componentWillReceiveProps: unit -> unit

    type [<AllowNullLiteral>] FreeCameraStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> FreeCamera

module Ground =
    type Scene = Babylonjs.BABYLON.Scene
    type Node = Babylonjs.BABYLON.Node
    type Mesh = Babylonjs.BABYLON.Mesh
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type MeshProps = MeshProps.MeshProps

    type [<AllowNullLiteral>] IExports =
        abstract Ground: GroundStatic

    type [<AllowNullLiteral>] GroundProps =
        interface end

    type [<AllowNullLiteral>] Ground =
        inherit SceneComponent.SceneComponent<Mesh, Node, GroundProps>
        abstract options: obj option with get, set
        abstract ground: obj option with get, set
        abstract componentWillReceiveProps: unit -> unit
        abstract create: scene: Scene -> Mesh
        abstract propsHandlers: ResizeArray<MeshProps.MeshPropsHandler>

    type [<AllowNullLiteral>] GroundStatic =
        [<Emit "new $0($1...)">] abstract Create: props: GroundProps -> Ground

module HemisphericLight =
    type Scene = Babylonjs.BABYLON.Scene
    type BabylonHemisphericLight = Babylonjs.BABYLON.HemisphericLight
    type Light = Babylonjs.BABYLON.Light
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type LightProps = LightProps.LightProps

    type [<AllowNullLiteral>] IExports =
        abstract HemisphericLight: HemisphericLightStatic

    type [<AllowNullLiteral>] HemisphericLightProps =
        interface end

    type [<AllowNullLiteral>] HemisphericLight =
        inherit SceneComponent.SceneComponent<BabylonHemisphericLight, Light, HemisphericLightProps>
        abstract light: obj option with get, set
        abstract create: scene: Scene -> BabylonHemisphericLight
        abstract propsHandlers: ResizeArray<LightProps.LightPropsHandler>

    type [<AllowNullLiteral>] HemisphericLightStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> HemisphericLight

module LightProps =
    type PropsHandler<'T1, 'T2> = SceneComponent.PropsHandler<'T1, 'T2>
    type Light = Babylonjs.BABYLON.Light

    type [<AllowNullLiteral>] IExports =
        abstract LightPropsHandler: LightPropsHandlerStatic

    type [<AllowNullLiteral>] LightProps =
        abstract intensity: float option with get, set

    type [<AllowNullLiteral>] LightPropsHandler =
        inherit PropsHandler<Light, LightProps>
        abstract handle: target: Light * props: LightProps -> unit

    type [<AllowNullLiteral>] LightPropsHandlerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LightPropsHandler

module MeshProps =
    type PropsHandler<'T1, 'T2> = SceneComponent.PropsHandler<'T1, 'T2>
    type Mesh = Babylonjs.BABYLON.Mesh
    type Vector3 = Babylonjs.BABYLON.Vector3

    type [<AllowNullLiteral>] IExports =
        abstract MeshPropsHandler: MeshPropsHandlerStatic

    type [<AllowNullLiteral>] MeshProps =
        abstract position: Vector3 option with get, set
        abstract showBoundingBox: bool option with get, set

    type [<AllowNullLiteral>] MeshPropsHandler =
        inherit PropsHandler<Mesh, MeshProps>
        abstract handle: target: Mesh * props: MeshProps -> unit

    type [<AllowNullLiteral>] MeshPropsHandlerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> MeshPropsHandler

module Middleware =

    type [<AllowNullLiteral>] IExports =
        abstract DEBUG_ON: string
        abstract DEBUG_OFF: string
        abstract debugOn: (unit -> obj)
        abstract debugOff: (unit -> obj)
        abstract actions: obj
        abstract registerHandler: ((obj -> bool) -> unit)
        abstract removeHandler: ((obj -> bool) -> unit)
        abstract _default: (obj option -> (obj option -> (obj option -> obj option)))

    type [<AllowNullLiteral>] HandledResult =
        abstract handled: bool with get, set
        abstract handlers: float with get, set
        abstract errors: ResizeArray<obj option> with get, set

module Model =
    type Scene = Babylonjs.BABYLON.Scene
    type ParticleSystem = Babylonjs.BABYLON.ParticleSystem
    type Skeleton = Babylonjs.BABYLON.Skeleton
    type AnimationGroup = Babylonjs.BABYLON.AnimationGroup
    type AbstractMesh = Babylonjs.BABYLON.AbstractMesh
    type ModelProps = ModelProps.ModelProps

    type [<AllowNullLiteral>] IExports =
        abstract LoadedModel: LoadedModelStatic
        abstract Model: ModelStatic

    type [<RequireQualifiedAccess>] LoaderStatus =
        | Loading = 0
        | Loaded = 1
        | Error = 2

    type [<AllowNullLiteral>] LoadedModel =
        abstract status: LoaderStatus option with get, set
        abstract rootMesh: AbstractMesh option with get, set
        abstract errorMessage: string option with get, set
        abstract loaderName: string option with get, set
        abstract meshes: ResizeArray<AbstractMesh> option with get, set
        abstract particleSystems: ResizeArray<ParticleSystem> option with get, set
        abstract skeletons: ResizeArray<Skeleton> option with get, set
        abstract animationGroups: ResizeArray<AnimationGroup> option with get, set

    type [<AllowNullLiteral>] LoadedModelStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> LoadedModel

    type [<AllowNullLiteral>] Model =
        inherit SceneComponent.SceneComponent<LoadedModel, LoadedModel, ModelProps>
        abstract options: obj option with get, set
        abstract loadedModel: obj option with get, set
        abstract create: scene: Scene -> LoadedModel
        abstract propsHandlers: ResizeArray<ModelProps.ModelPropsHandler>

    type [<AllowNullLiteral>] ModelStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> Model

module ModelProps =
    type Vector3 = Babylonjs.BABYLON.Vector3
    type LoadedModel = Model.LoadedModel
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type PropsHandler<'T1, 'T2>= SceneComponent.PropsHandler<'T1, 'T2>

    type [<AllowNullLiteral>] IExports =
        abstract ModelPropsHandler: ModelPropsHandlerStatic

    type [<AllowNullLiteral>] ModelProps =
        interface end

    type [<AllowNullLiteral>] ModelPropsHandler =
        inherit PropsHandler<LoadedModel, ModelProps>
        abstract handle: loadedModel: LoadedModel * props: ModelProps -> unit

    type [<AllowNullLiteral>] ModelPropsHandlerStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> ModelPropsHandler

module RotateMeshBehaviour =
    type Component<'T1, 'T2> = React.Component<'T1, 'T2>
    type Behaviour<'T> = SceneComponent.Behaviour<'T>
    type ComponentContainerProps = SceneComponent.ComponentContainerProps
    type Scene = Babylonjs.BABYLON.Scene
    type Vector3 = Babylonjs.BABYLON.Vector3
    type AbstractMesh = Babylonjs.BABYLON.AbstractMesh

    type [<AllowNullLiteral>] IExports =
        abstract RotateMeshBehaviour: RotateMeshBehaviourStatic

    type [<AllowNullLiteral>] RotateMeshBehaviourProps =
        interface end
    [<AbstractClass>]
    type [<AllowNullLiteral>] RotateMeshBehaviour =
        inherit Component<RotateMeshBehaviourProps, obj>
        inherit Behaviour<AbstractMesh>
        abstract behaviourAdded: bool with get, set
        abstract options: obj option with get, set
        abstract apply: target: AbstractMesh * scene: Scene -> unit
        abstract render: unit -> obj

    type [<AllowNullLiteral>] RotateMeshBehaviourStatic =
        [<Emit "new $0($1...)">] abstract Create: props: RotateMeshBehaviourProps -> RotateMeshBehaviour

module Scene =
    type EngineOptions = Babylonjs.BABYLON.EngineOptions
    type BabylonScene = Babylonjs.BABYLON.Scene
    type AbstractMesh = Babylonjs.BABYLON.AbstractMesh
    type Camera = Babylonjs.BABYLON.Camera

    type [<AllowNullLiteral>] IExports =
        abstract Scene: SceneStatic

    type [<AllowNullLiteral>] SceneEventArgs =
        abstract scene: BabylonScene with get, set
        abstract canvas: HTMLCanvasElement with get, set

    type [<AllowNullLiteral>] ComponentContainer =
        abstract onRegisterChild: (obj option -> unit) with get, set

    type [<AllowNullLiteral>] SceneProps =
        /// Called after createCamera(...), if exists.  This must attach a camera to a canvas, if you did not implement a createCamera().
        abstract onSceneMount: (SceneEventArgs -> unit) option with get, set
        /// By implementing this, the camera is attached to the canvas automatically.
        abstract createCamera: (SceneEventArgs -> Camera) option with get, set
        abstract onSceneBlur: (SceneEventArgs -> unit) option with get, set
        abstract onSceneFocus: (SceneEventArgs -> unit) option with get, set
        abstract onMeshPicked: (AbstractMesh -> BabylonScene -> unit) option with get, set
        abstract shadersRepository: string option with get, set
        abstract engineOptions: EngineOptions option with get, set
        abstract adaptToDeviceRatio: bool option with get, set
        abstract width: float option with get, set
        abstract height: float option with get, set
        abstract touchActionNone: bool option with get, set
        abstract id: string option with get, set
        abstract debug: bool option with get, set

    type [<AllowNullLiteral>] Scene =
        inherit React.Component<obj, obj>
        inherit ComponentContainer
        abstract scene: obj option with get, set
        abstract engine: obj option with get, set
        abstract height: obj option with get, set
        abstract width: obj option with get, set
        abstract canvas3d: obj option with get, set
        abstract actionHandler: obj with get, set
        abstract onResizeWindow: (unit -> unit) with get, set
        abstract componentDidMount: unit -> unit
        abstract componentWillUnmount: unit -> unit
        abstract onCanvas3d: (HTMLCanvasElement -> unit) with get, set
        /// When canvas receives the active focus (ie: mouse over) intercept keypresses (should be optional behaviour)
        abstract focus: (unit -> unit) with get, set
        /// When canvas loses focus (ie: mouse out) intercept keypresses (should be optional behaviour)
        abstract blur: (unit -> unit) with get, set
        abstract keyPressHandler: (KeyboardEvent -> unit) with get, set
        abstract onRegisterChild: child: obj option -> unit
        abstract render: unit -> JSX.Element

    type [<AllowNullLiteral>] SceneStatic =
        [<Emit "new $0($1...)">] abstract Create: props: SceneProps -> Scene

module SceneComponent =
    type Component<'T1, 'T2> = React.Component<'T1, 'T2>
    type Scene = Babylonjs.BABYLON.Scene
    type Vector3 = Babylonjs.BABYLON.Vector3
    type Nullable<'T> = Babylonjs.BABYLON.Nullable<'T>
    type AbstractMesh = Babylonjs.BABYLON.AbstractMesh
    type BabylonMaterial = Babylonjs.BABYLON.Material
    type ComponentContainer = Scene.ComponentContainer

    type [<AllowNullLiteral>] IExports =
        abstract SceneComponent: SceneComponentStatic

    type [<AllowNullLiteral>] Behaviour<'T> =
        abstract apply: target: 'T * scene: Scene -> unit

    type [<AllowNullLiteral>] Material<'T> =
        abstract material: BabylonMaterial option with get, set
        abstract apply: target: 'T * scene: Scene -> unit

    type [<AllowNullLiteral>] ComponentContainerProps =
        abstract scene: Scene with get, set
        abstract name: string with get, set
        abstract container: obj option with get, set
        abstract addBehaviour: (obj option -> unit) with get, set
        abstract setMaterial: (Material<AbstractMesh> -> unit) with get, set

    type [<AllowNullLiteral>] SceneComponentProps<'T> =
        interface end

    type [<AllowNullLiteral>] NodeProps =
        abstract position: Vector3 with get, set

    type [<AllowNullLiteral>] PropsHandler<'T, 'U> =
        abstract handle: target: 'T * props: 'U -> unit

    /// Base implemention of SceneComponent.  Currently all classes are inheriting from this.
    type [<AllowNullLiteral>] SceneComponent<'T, 'U, 'V> =
        inherit Component<'V, obj>
        inherit ComponentContainer
        abstract name: string option with get, set
        abstract babylonObject: obj option with get, set
        abstract hasRendered: obj with get, set
        abstract behaviours: obj with get, set
        abstract materialComponent: obj option with get, set
        /// <summary>Called once for each Scene Component</summary>
        /// <param name="scene">babylonJS scene</param>
        abstract create: scene: Scene -> 'T
        abstract propsHandlers: ResizeArray<PropsHandler<'U, 'V>>
        abstract addBehaviour: behaviour: Behaviour<'U> -> unit
        abstract setMaterial: material: Material<AbstractMesh> -> unit
        /// <param name="child">called by child passing in their created <T></param>
        abstract onRegisterChild: child: 'T -> unit
        abstract render: unit -> JSX.Element

    /// Base implemention of SceneComponent.  Currently all classes are inheriting from this.
    type [<AllowNullLiteral>] SceneComponentStatic =
        [<Emit "new $0($1...)">] abstract Create: props: 'V * ?context: obj option -> SceneComponent<'T, 'U, 'V>

module Sphere =
    type Scene = Babylonjs.BABYLON.Scene
    type Node = Babylonjs.BABYLON.Node
    type Mesh = Babylonjs.BABYLON.Mesh
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>
    type MeshProps = MeshProps.MeshProps

    type [<AllowNullLiteral>] IExports =
        abstract Sphere: SphereStatic

    type [<AllowNullLiteral>] SphereProps =
        interface end

    type [<AllowNullLiteral>] Sphere =
        inherit SceneComponent<Mesh, Node, SphereProps>
        abstract options: obj option with get, set
        abstract sphere: obj option with get, set
        abstract componentWillReceiveProps: unit -> unit
        abstract create: scene: Scene -> Mesh
        abstract propsHandlers: ResizeArray<MeshPropsHandler>

    type [<AllowNullLiteral>] SphereStatic =
        [<Emit "new $0($1...)">] abstract Create: props: SphereProps -> Sphere

module StandardMaterial =
    type Component<'T1, 'T2> = React.Component<'T1, 'T2>
    type Material<'T> = SceneComponent.Material<'T>
    type ComponentContainerProps = SceneComponent.ComponentContainerProps
    type Scene = Babylonjs.BABYLON.Scene
    type BabylonMaterial = Babylonjs.BABYLON.Material
    type AbstractMesh = Babylonjs.BABYLON.AbstractMesh
    type Color3 = Babylonjs.BABYLON.Color3

    type [<AllowNullLiteral>] IExports =
        abstract StandardMaterial: StandardMaterialStatic

    type [<AllowNullLiteral>] StandardMaterialProps =
        interface end

    type [<AllowNullLiteral>] StandardMaterial =
        inherit Component<StandardMaterialProps, obj>
        inherit Material<AbstractMesh>
        abstract material: BabylonMaterial option with get, set
        abstract materialSet: bool with get, set
        abstract options: obj option with get, set
        abstract apply: target: AbstractMesh * scene: Scene -> unit
        abstract render: unit -> obj

    type [<AllowNullLiteral>] StandardMaterialStatic =
        [<Emit "new $0($1...)">] abstract Create: props: StandardMaterialProps -> StandardMaterial

module VRExperience =
    type Scene = Babylonjs.BABYLON.Scene
    type VRExperienceHelper = Babylonjs.BABYLON.VRExperienceHelper
    type VRExperienceHelperOptions = Babylonjs.BABYLON.VRExperienceHelperOptions
    type SceneComponentProps<'T> = SceneComponent.SceneComponentProps<'T>

    type [<AllowNullLiteral>] IExports =
        abstract VRExperience: VRExperienceStatic

    type [<AllowNullLiteral>] VRExperienceProps =
        interface end

    type [<AllowNullLiteral>] VRExperience =
        inherit SceneComponent.SceneComponent<VRExperienceHelper, VRExperienceHelper, VRExperienceProps>
        abstract experienceHelper: obj option with get, set
        abstract create: createdScene: Scene -> VRExperienceHelper
        abstract propsHandlers: ResizeArray<obj>

    type [<AllowNullLiteral>] VRExperienceStatic =
        [<Emit "new $0($1...)">] abstract Create: unit -> VRExperience
