using iRacingSdkWrapper;
using iRacingSdkWrapper.Bitfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingMock.ClassLibrary
{
    class MockTelemetryInfo : ITelemetryInfo
    {
        private Dictionary<int, Dictionary<string, string>> _telemetryInfos;
        private int _count;

        public MockTelemetryInfo(Dictionary<int, Dictionary<string, string>> telemetryInfos, int count)
        {
            _telemetryInfos = telemetryInfos;
            _count = count;
        }

        public ITelemetryValue<float> MGUKDeployAdapt {get; set;}

        public ITelemetryValue<float> MGUKDeployFixed {get; set;}

        public ITelemetryValue<float> MGUKRegenGain {get; set;}

        public ITelemetryValue<float> EnergyBatteryToMGU {get; set;}

        public ITelemetryValue<float> EnergyBudgetBattToMGU {get; set;}

        public ITelemetryValue<float> EnergyERSBattery {get; set;}

        public ITelemetryValue<float> PowerMGUH {get; set;}

        public ITelemetryValue<float> PowerMGUK {get; set;}

        public ITelemetryValue<float> TorqueMGUK {get; set;}

        public ITelemetryValue<int> DrsStatus {get; set;}

        public ITelemetryValue<int> LapCompleted {get; set;}

        public ITelemetryValue<double> SessionTime {get; set;}

        public ITelemetryValue<int> SessionNum
        {
            get { return new MockTelemetryValue<int>() { Value = Convert.ToInt32(_telemetryInfos[_count][nameof(SessionNum)]) }; }
            set { }
        }

        public ITelemetryValue<SessionStates> SessionState {get; set;}

        public ITelemetryValue<int> SessionUniqueID {get; set;}

        public ITelemetryValue<SessionFlag> SessionFlags {get; set;}

        public ITelemetryValue<bool> DriverMarker {get; set;}

        public ITelemetryValue<bool> IsReplayPlaying {get; set;}

        public ITelemetryValue<int> ReplayFrameNum {get; set;}

        public ITelemetryValue<int[]> CarIdxLap {get; set;}

        public ITelemetryValue<int[]> CarIdxLapCompleted {get; set;}

        public ITelemetryValue<float[]> CarIdxLapDistPct {get; set;}

        public ITelemetryValue<TrackSurfaces[]> CarIdxTrackSurface {get; set;}

        public ITelemetryValue<float[]> CarIdxSteer {get; set;}

        public ITelemetryValue<float[]> CarIdxRPM {get; set;}

        public ITelemetryValue<int[]> CarIdxGear {get; set;}

        public ITelemetryValue<float[]> CarIdxF2Time {get; set;}

        public ITelemetryValue<float[]> CarIdxEstTime {get; set;}

        public ITelemetryValue<bool[]> CarIdxOnPitRoad {get; set;}

        public ITelemetryValue<int[]> CarIdxPosition {get; set;}

        public ITelemetryValue<int[]> CarIdxClassPosition {get; set;}

        public ITelemetryValue<float> SteeringWheelAngle {get; set;}

        public ITelemetryValue<float> Throttle {
            get { return new MockTelemetryValue<float>() { Value = Convert.ToSingle(_telemetryInfos[_count][nameof(Throttle)]) }; }
            set { }
        }

        public ITelemetryValue<float> Brake {
            get { return new MockTelemetryValue<float>() { Value = Convert.ToSingle(_telemetryInfos[_count][nameof(Brake)]) }; }
            set { }
        }

        public ITelemetryValue<float> Clutch {get; set;}

        public ITelemetryValue<int> Gear {
            get { return new MockTelemetryValue<int>() { Value = Convert.ToInt32(_telemetryInfos[_count][nameof(Gear)]) }; }
            set { }
        }

        public ITelemetryValue<float> RPM {
            get { return new MockTelemetryValue<float>() { Value = Convert.ToSingle(_telemetryInfos[_count][nameof(RPM)]) }; }
            set { }
        }

        public ITelemetryValue<int> Lap {
            get { return new MockTelemetryValue<int>() { Value = Convert.ToInt32(_telemetryInfos[_count][nameof(Lap)]) }; }
            set { }
        }

        public ITelemetryValue<float> LapDist {
            get { return new MockTelemetryValue<float>() { Value = Convert.ToSingle(_telemetryInfos[_count][nameof(LapDist)]) }; }
            set { }
        }

        public ITelemetryValue<float> LapDistPct {get; set;}

        public ITelemetryValue<int> RaceLaps {get; set;}

        public ITelemetryValue<float> LongAccel {get; set;}

        public ITelemetryValue<float> LatAccel {get; set;}

        public ITelemetryValue<float> VertAccel {get; set;}

        public ITelemetryValue<float> RollRate {get; set;}

        public ITelemetryValue<float> PitchRate {get; set;}

        public ITelemetryValue<float> YawRate {get; set;}

        public ITelemetryValue<float> Speed
        {
            get { return new MockTelemetryValue<float>() {Value = Convert.ToSingle(_telemetryInfos[_count][nameof(Speed)])}; }
            set { }
        }

        public ITelemetryValue<float> VelocityX {get; set;}

        public ITelemetryValue<float> VelocityY {get; set;}

        public ITelemetryValue<float> VelocityZ {get; set;}

        public ITelemetryValue<float> Yaw {get; set;}

        public ITelemetryValue<float> Pitch {get; set;}

        public ITelemetryValue<float> Roll {get; set;}

        public ITelemetryValue<int> CamCarIdx {get; set;}

        public ITelemetryValue<int> CamCameraNumber {get; set;}

        public ITelemetryValue<int> CamGroupNumber {get; set;}

        public ITelemetryValue<CameraState> CamCameraState {get; set;}

        public ITelemetryValue<bool> IsOnTrack {
            get { return new MockTelemetryValue<bool>() { Value = Convert.ToBoolean(_telemetryInfos[_count][nameof(IsOnTrack)]) }; }
            set { }
        }

        public ITelemetryValue<bool> IsInGarage {get; set;}

        public ITelemetryValue<float> SteeringWheelTorque {get; set;}

        public ITelemetryValue<float> SteeringWheelPctTorque {get; set;}

        public ITelemetryValue<float> ShiftIndicatorPct {get; set;}

        public ITelemetryValue<EngineWarning> EngineWarnings {
            get { return new MockTelemetryValue<EngineWarning>() { Value = new EngineWarning(Convert.ToInt32(_telemetryInfos[_count][nameof(EngineWarnings)])) }; }
            set { }
        }

        public ITelemetryValue<float> FuelLevel {
            get { return new MockTelemetryValue<float>() { Value = Convert.ToSingle(_telemetryInfos[_count][nameof(FuelLevel)]) }; }
            set { }
        }

        public ITelemetryValue<float> FuelLevelPct {get; set;}

        public ITelemetryValue<int> ReplayPlaySpeed {get; set;}

        public ITelemetryValue<bool> ReplayPlaySlowMotion {get; set;}

        public ITelemetryValue<double> ReplaySessionTime {get; set;}

        public ITelemetryValue<int> ReplaySessionNum {get; set;}

        public ITelemetryValue<float> WaterTemp {get; set;}

        public ITelemetryValue<float> WaterLevel {get; set;}

        public ITelemetryValue<float> FuelPress {get; set;}

        public ITelemetryValue<float> OilTemp {get; set;}

        public ITelemetryValue<float> OilPress {get; set;}

        public ITelemetryValue<float> OilLevel {get; set;}

        public ITelemetryValue<float> Voltage {get; set;}

        public ITelemetryValue<double> SessionTimeRemain {
            get { return new MockTelemetryValue<double>() { Value = Convert.ToDouble(_telemetryInfos[_count][nameof(SessionTimeRemain)]) }; }
            set { }
        }

        public ITelemetryValue<int> ReplayFrameNumEnd {get; set;}

        public ITelemetryValue<float> AirDensity {get; set;}

        public ITelemetryValue<float> AirPressure {get; set;}

        public ITelemetryValue<float> AirTemp {get; set;}

        public ITelemetryValue<float> FogLevel {get; set;}

        public ITelemetryValue<int> Skies {get; set;}

        public ITelemetryValue<float> TrackTemp {get; set;}

        public ITelemetryValue<float> TrackTempCrew {get; set;}

        public ITelemetryValue<float> RelativeHumidity {get; set;}

        public ITelemetryValue<int> WeatherType {get; set;}

        public ITelemetryValue<float> WindDir {get; set;}

        public ITelemetryValue<float> WindVel {get; set;}

        public ITelemetryValue<int> PlayerCarTeamIncidentCount {get; set;}

        public ITelemetryValue<int> PlayerCarMyIncidentCount {get; set;}

        public ITelemetryValue<int> PlayerCarDriverIncidentCount {get; set;}

        public ITelemetryValue<TrackSurfaces> PlayerTrackSurface {get; set;}

        public ITelemetryValue<int> PlayerCarIdx {get; set;}
    }
}
